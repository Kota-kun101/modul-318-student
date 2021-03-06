﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Globalization;
using System.Net.Mail;
using System.Device.Location;
using System.Diagnostics;

namespace MyTransportApp
{
    public partial class Form1 : Form
    {
        ITransport _transport = new Transport();

        GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

        void watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            GeoCoordinate coord = watcher.Position.Location;
            if (coord.IsUnknown != true)
            {
                Stations stations = _transport.GetCloseStations(coord.Latitude.ToString(), coord.Longitude.ToString());
                foreach (Station station in stations.StationList)
                {
                    dataGridView_closestations.Rows.Add(station.Name, station.Distance + " m");
                }
            }
            else
            {
                Console.WriteLine("Unknown latitude and longitude.");
                System.Threading.Thread.Sleep(1000);
            }
        }

        public Form1()
        {
            InitializeComponent();
            zeitinput.Text = DateTime.Now.ToString("HH:mm", CultureInfo.InvariantCulture);
            AbfahrtsdatumEingabe.Value = Convert.ToDateTime(DateTime.Now.ToString("MMMM dd, yyyy", CultureInfo.InvariantCulture));
            watcher.Start();
            watcher.TryStart(false, TimeSpan.FromMilliseconds(100000));
            watcher.StatusChanged += new EventHandler<GeoPositionStatusChangedEventArgs>(watcher_StatusChanged);
        }

        private void btn_switch_Click(object sender, EventArgs e)
        {
            string startStationName = startStationCombobox.Text;
            startStationCombobox.Text = EndstationCombobox.Text;
            EndstationCombobox.Text = startStationName;
        }

        private void btn_Abfahrtstafel_Click(object sender, EventArgs e)
        {
            Stations stations = _transport.GetStations(query: abfahrtInputCombobox.Text);
            if (stations.StationList[0].Id != "")
            {
                StationBoardRoot stationBoardRoot = _transport.GetStationBoard(stations.StationList[0].Name, stations.StationList[0].Id);
                foreach(StationBoard stationBoard in stationBoardRoot.Entries)
                {
                    dataGridView_Abfahrtstafel.Rows.Add(stationBoard.Number , stationBoard.Stop.Departure, stationBoard.To);
                }
            }
        }

        private void btn_Verbindungen_Click(object sender, EventArgs e)
        {
            dataGridView_Verbindungen.Rows.Clear();
            var abfahrtsdatum = DateTime.Parse(AbfahrtsdatumEingabe.Value.ToString());

            Connections connections = _transport.GetConnections(startStationCombobox.Text, EndstationCombobox.Text, abfahrtsdatum.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), zeitinput.Text);
            foreach(Connection connection in connections.ConnectionList)
            {
                var departure = DateTime.Parse(connection.From.Departure);
                var arrival = DateTime.Parse(connection.To.Arrival);
                var reisezeit = arrival - departure; //connection.Duration;

                dataGridView_Verbindungen.Rows.Add(departure.ToString("HH:mm", CultureInfo.InvariantCulture) + " Uhr", connection.To.Station.Name, reisezeit, arrival.ToString("HH:mm", CultureInfo.InvariantCulture) + " Uhr");
            }
        }

        private void opnMap_Click(object sender, EventArgs e)
        {
            Stations stations = _transport.GetStations(query: startStationCombobox.Text);
            if (stations.StationList.Count != 0)
            {
                double coordinateX = stations.StationList[0].Coordinate.XCoordinate;
                double coordinateY = stations.StationList[0].Coordinate.YCoordinate;

                Form2 form2 = new Form2(coordinateX, coordinateY);
                form2.Show();
            }

        }

        private void startStationCombobox_KeyUp(object sender, KeyEventArgs e)
        {
            if (startStationCombobox.Text != "")
            {
                Stations stations = _transport.GetStations(query: startStationCombobox.Text);
                startStationCombobox.Items.Clear();

                foreach (Station station in stations.StationList)
                {
                    if (station.Name != "")
                    {
                        startStationCombobox.Focus();
                        startStationCombobox.SelectionStart = startStationCombobox.Text.Length;
                        startStationCombobox.Items.Add(station.Name);
                    }
                }
            }
        }

        private void EndstationCombobox_KeyUp(object sender, KeyEventArgs e)
        {
            if (EndstationCombobox.Text != "")
            {
                Stations stations = _transport.GetStations(query: EndstationCombobox.Text);
                EndstationCombobox.Items.Clear();

                foreach (Station station in stations.StationList)
                {
                    if (station.Name != "")
                    {
                        EndstationCombobox.Focus();
                        EndstationCombobox.SelectionStart = EndstationCombobox.Text.Length;
                        EndstationCombobox.Items.Add(station.Name);
                    }
                }
            }
        }

        private void abfahrtInputCombobox_KeyUp(object sender, KeyEventArgs e)
        {
            if (abfahrtInputCombobox.Text != "")
            {
                Stations stations = _transport.GetStations(query: abfahrtInputCombobox.Text);
                abfahrtInputCombobox.Items.Clear();

                foreach (Station station in stations.StationList)
                {
                    if (station.Name != "")
                    {
                        abfahrtInputCombobox.Focus();
                        abfahrtInputCombobox.SelectionStart = abfahrtInputCombobox.Text.Length;
                        abfahrtInputCombobox.Items.Add(station.Name);
                    }
                }
            }
        }

        private void dataGridView_Verbindungen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView_Verbindungen.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string abfahrt = dataGridView_Verbindungen.Rows[e.RowIndex].Cells["Abfahrt"].FormattedValue.ToString();
                string richtung = dataGridView_Verbindungen.Rows[e.RowIndex].Cells["Richtung"].FormattedValue.ToString();
                string reisezeit = dataGridView_Verbindungen.Rows[e.RowIndex].Cells["Reisezeit"].FormattedValue.ToString();
                string ankunft = dataGridView_Verbindungen.Rows[e.RowIndex].Cells["Ankunft"].FormattedValue.ToString();

                string body = "Abfahrt: " + abfahrt + " Richtung: " + richtung + " Reisezeit: " + reisezeit + " Ankunft: " + ankunft;

                Process.Start(
                    "mailto:" + "" +
                    "?subject=" + "Verbindung Teilen" +
                    "&body=" + body
                    );
            }
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            watcher.StatusChanged += new EventHandler<GeoPositionStatusChangedEventArgs>(watcher_StatusChanged);
        }
    }
}

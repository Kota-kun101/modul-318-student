using System;
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

namespace MyTransportApp
{
    public partial class Form1 : Form
    {
        ITransport _transport = new Transport();

        public Form1()
        {
            InitializeComponent();
            zeitinput.Text = DateTime.Now.ToString("HH:mm", CultureInfo.InvariantCulture);
            AbfahrtsdatumEingabe.Value = Convert.ToDateTime(DateTime.Now.ToString("MMMM dd, yyyy", CultureInfo.InvariantCulture));
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

        private void startStationCombobox_TextChanged(object sender, EventArgs e)
        {
            if (startStationCombobox.Text != "")
            {
                Stations stations = _transport.GetStations(query: startStationCombobox.Text);
                //startStationCombobox.Items.Clear();

                foreach (Station station in stations.StationList)
                {
                    if (station.Name != "")
                    {
                        /*startStationCombobox.Focus();
                        startStationCombobox.SelectionStart = startStationCombobox.Text.Length;*/
                        startStationCombobox.Items.Add(station.Name);
                    }
                }
            }
        }

        private void EndstationCombobox_TextChanged(object sender, EventArgs e)
        {
            if (EndstationCombobox.Text != "")
            {
                Stations stations = _transport.GetStations(query: EndstationCombobox.Text);
                //EndstationCombobox.Items.Clear();

                foreach (Station station in stations.StationList)
                {
                    if (station.Name != "")
                    {
                        EndstationCombobox.Items.Add(station.Name);
                    }
                }
            }
        }

        private void abfahrtInputCombobox_TextChanged(object sender, EventArgs e)
        {
            if (abfahrtInputCombobox.Text != "")
            {
                Stations stations = _transport.GetStations(query: abfahrtInputCombobox.Text);
                //abfahrtInputCombobox.Items.Clear();

                foreach (Station station in stations.StationList)
                {
                    if (station.Name != "")
                    {
                        abfahrtInputCombobox.Items.Add(station.Name);
                    }
                }
            }
        }

        private void dataGridView_Verbindungen_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sendMessage();
        }

        void sendMessage()
        {
            string to = "kota.schnider@gmail.com";
            string from = "ben@contoso.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Using the new SMTP client.";
            message.Body = @"Using this new feature, you can send an email message from an application very easily.";
            SmtpClient client = new SmtpClient();
            // Credentials are necessary if the server requires the client
            // to authenticate before it will send email on the client's behalf.
            client.UseDefaultCredentials = true;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
        }

        private void opnMap_Click(object sender, EventArgs e)
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));
            GeoCoordinate coord = watcher.Position.Location;

            double x = 0.0;
            double y = 0.0;
            
            if (coord.IsUnknown != true)
            {
                x = coord.Latitude;
                y = coord.Longitude;
            }
            else
            {
                Console.WriteLine("Unknown latitude and longitude.");
            }

            Stations stations = _transport.GetStations(query: startStationCombobox.Text);
            double coordinateX = stations.StationList[0].Coordinate.XCoordinate;
            double coordinateY = stations.StationList[0].Coordinate.YCoordinate;

            Form2 form2 = new Form2(coordinateX, coordinateY, x, y);
            form2.Show();
        }
    }
}

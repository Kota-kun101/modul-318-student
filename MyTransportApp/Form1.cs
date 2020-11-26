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
            string startStationName = startstationInput.Text;
            startstationInput.Text = endstationInput.Text;
            endstationInput.Text = startStationName;
        }

        private void btn_Abfahrtstafel_Click(object sender, EventArgs e)
        {

        }

        private void btn_Verbindungen_Click(object sender, EventArgs e)
        {
            dataGridView_Verbindungen.Rows.Clear();

            Connections connections = _transport.GetConnections(startstationInput.Text, endstationInput.Text);
            foreach(Connection connection in connections.ConnectionList)
            {
                var departure = DateTime.Parse(connection.From.Departure);
                var arrival = DateTime.Parse(connection.To.Arrival);
                var reisezeit = arrival - departure; //connection.Duration;

                dataGridView_Verbindungen.Rows.Add(departure.ToString("HH:mm", CultureInfo.InvariantCulture) + " Uhr", connection.To.Station.Name, reisezeit, arrival.ToString("HH:mm", CultureInfo.InvariantCulture) + " Uhr");
            }
        }

        private void startstationInput_Leave(object sender, EventArgs e)
        {
            Stations stations = _transport.GetStations(query: startstationInput.Text);
            if (stations.StationList.Count != 0)
            {
                startstationInput.Text = stations.StationList[0].Name;
            }
        }

        private void endstationInput_Leave(object sender, EventArgs e)
        {
            Stations stations = _transport.GetStations(query: endstationInput.Text);
            if(stations.StationList.Count != 0)
            {
                endstationInput.Text = stations.StationList[0].Name;
            }
        }

        private void startstationInput_TextChanged(object sender, EventArgs e)
        {
            Stations stations = _transport.GetStations(query: startstationInput.Text);
            //startstationInput.AutoCompleteCustomSource.Clear();
            
            /*foreach(Station station in stations.StationList)
            {
                if(station.Name != "")
                {
                    //startstationInput.AutoCompleteCustomSource.Add(station.Name);
                    Console.WriteLine(station.Name);
                }
            }*/
        }

        private void endstationInput_TextChanged(object sender, EventArgs e)
        {
            Stations stations = _transport.GetStations(query: endstationInput.Text);
            //endstationInput.AutoCompleteCustomSource.Clear();
            /*foreach (Station station in stations.StationList)
            {
                if (station.Name != "")
                {
                    //endstationInput.AutoCompleteCustomSource.Add(station.Name);
                    Console.WriteLine(station.Name);
                }
            }*/
        }
    }
}

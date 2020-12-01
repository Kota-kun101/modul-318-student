using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class Form2 : Form
    {
        double LatInicial = 0.0;
        double LngInicial = 0.0;

        double MyLatInicial = 0.0;
        double MyLngInicial = 0.0;
        public Form2(double x, double y, double myX, double myY)
        {
            InitializeComponent();
            LatInicial = x;
            LngInicial = y;
            MyLatInicial = myX;
            MyLngInicial = myY;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Console.WriteLine(MyLngInicial + " " + MyLatInicial);
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            GMapOverlay markersOverlay = new GMapOverlay("marker1");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.red);
            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markersOverlay);

            GMapOverlay myMarkersOverlay = new GMapOverlay("marker2");
            GMarkerGoogle myMarker = new GMarkerGoogle(new PointLatLng(MyLatInicial, MyLngInicial), GMarkerGoogleType.green);
            myMarkersOverlay.Markers.Add(myMarker);
            gMapControl1.Overlays.Add(myMarkersOverlay);
        }
    }
}

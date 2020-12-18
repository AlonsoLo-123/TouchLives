
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Windows.Forms;
using GMap.NET;
using Google.Cloud.Firestore;
using System.Threading.Tasks;
using System;
using System.Drawing;

namespace TouchLives.Map
{
    class Maps
    {
        public void DrawMap(GMapControl GMap, GeoPoint position)
        {
            GMap.MapProvider = GMapProviders.GoogleMap;
            GMap.DragButton = MouseButtons.Left;
            GMap.CanDragMap = true;
            GMap.Position = new GMap.NET.PointLatLng(position.Latitude,position.Longitude);
            GMap.MinZoom = 10;
            GMap.MaxZoom = 20;
            GMap.Zoom = 13;
            GMap.AutoScroll = true;
            GMap.ShowCenter = true;
        }
        public void MapPosition(GMapControl GMap, GeoPoint position)
        {
            GMap.Position = new GMap.NET.PointLatLng(position.Latitude, position.Longitude);
        }

        /// Activar/Desactivar Vista satelital
        /// 
        public bool Sat_DrawMap(GMapControl GMap)
        {
            GMap.MapProvider = GMapProviders.GoogleSatelliteMap;
            GMap.Refresh();
            return true;
        }

        public bool Map_DrawMap(GMapControl GMap)
        {
            GMap.MapProvider = GMapProviders.GoogleMap;
            GMap.Refresh();
            return false;
        }
        ///
        /// Activar/Desactivar Vista satelital


        public GMapOverlay CreateMapMaker(ModUserAlertsId Alert, ModTablaUser UserDataNoti)
        {
            Bitmap MarkerAlert = (Bitmap)Image.FromFile(@"Maps/Markers/Marker.png");
            Console.WriteLine(Alert.date.ToString());
            
            GMapOverlay MarkOverlay = new GMapOverlay(Alert.Id);
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Alert.localizaction.Latitude, Alert.localizaction.Longitude), GMarkerGoogleType.black_small);

            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            //marker.ToolTip.Fill = Brushes.Black;
            //marker.ToolTip.Foreground = Brushes.White;
            //marker.ToolTip.Stroke = Pens.Black;
            //marker.ToolTip.TextPadding = new Size(20, 20);

            marker.ToolTipText = string.Format("Nombre: {0} {1} {2}\nTeléfono: {3}",UserDataNoti.nombre, UserDataNoti.ap_paterno, UserDataNoti.ap_materno, UserDataNoti.telefono);

            MarkOverlay.Markers.Add(marker);
            //MarkOverlay.Markers.Remove(marker);
            return MarkOverlay;
        }
    }
}

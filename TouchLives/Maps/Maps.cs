
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Windows.Forms;
using GMap.NET;
using Google.Cloud.Firestore;
using System.Threading.Tasks;
using System;

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
            GMap.MinZoom = 14;
            GMap.MaxZoom = 19;
            GMap.Zoom = 1;
            GMap.AutoScroll = true;
        }
        public void MapPosition(GMapControl GMap, GeoPoint position)
        {
            GMap.Position = new GMap.NET.PointLatLng(position.Latitude, position.Longitude);
        }

        public GMapOverlay CreateMapMaker(ModUserAlerts Alert, ModTablaUser UserDataNoti)
        {
            Console.WriteLine(Alert.position.ToString());
            
            GMapOverlay MarkOverlay = new GMapOverlay(Alert.position.ToString());
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Alert.position.Latitude, Alert.position.Longitude), GMarkerGoogleType.black_small);

            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Nombre: {0}\nTeléfono: {1}",UserDataNoti.nombre, UserDataNoti.telefono);

            MarkOverlay.Markers.Add(marker);

            return MarkOverlay;
        }
    }
}

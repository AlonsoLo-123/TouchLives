
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
            GMap.MinZoom = 12;
            GMap.MaxZoom = 20;
            GMap.Zoom = 10;
            GMap.AutoScroll = true;
        }
        public void MapPosition(GMapControl GMap, GeoPoint position)
        {
            GMap.Position = new GMap.NET.PointLatLng(position.Latitude, position.Longitude);
        }

        public bool Sat_DrawMap(GMapControl GMap)
        {
            GMap.MapProvider = GMapProviders.GoogleSatelliteMap;
            return true;
        }

        public bool Map_DrawMap(GMapControl GMap)
        {
            GMap.MapProvider = GMapProviders.GoogleMap;
            return false;
        }

        public GMapOverlay CreateMapMaker(ModUserAlerts Alert, ModTablaUser UserDataNoti)
        {
            Console.WriteLine(Alert.date.ToString());
            
            GMapOverlay MarkOverlay = new GMapOverlay(Alert.localizaction.ToString());
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Alert.localizaction.Latitude, Alert.localizaction.Longitude), GMarkerGoogleType.black_small);

            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Nombre: {0} {1} {2}\nTeléfono: {3}",UserDataNoti.nombre, UserDataNoti.ap_paterno, UserDataNoti.ap_materno, UserDataNoti.telefono);

            MarkOverlay.Markers.Add(marker);

            return MarkOverlay;
        }
    }
}

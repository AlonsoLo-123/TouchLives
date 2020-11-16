using Google.Cloud.Firestore;
using Google.Type;
using System.Collections.Generic;

namespace TouchLives
{
    public class ModelTables
    {
    }
    [FirestoreData]
    public class ModTablaUser
    {
        //Datos del usuario
        [FirestoreProperty]
        public string Id { get; set; }
        [FirestoreProperty]
        public string ap_materno { get; set; }
        [FirestoreProperty]
        public string ap_paterno { get; set; }
        [FirestoreProperty]
        public string email { get; set; }
        [FirestoreProperty]
        public string nombre { get; set; }
        [FirestoreProperty]
        public dynamic noti { get; set; }
        [FirestoreProperty]
        public string password { get; set; }
        [FirestoreProperty]
        public string telefono { get; set; }
    }
    [FirestoreData]
    public class ModUserAlerts
    {
        //Datos de las alertas
        [FirestoreProperty]
        public bool active { get; set; }
        [FirestoreProperty]
        public Date date { get; set; }
        [FirestoreProperty]
        public GeoPoint localizaction { get; set; }

        [FirestoreProperty]
        public Location sendLocation { get; set; }
    }
    [FirestoreData]
    public class Location
    {
        //Datos de sendLocation
        [FirestoreProperty]
        public string city { get; set; }
        [FirestoreProperty]
        public string country { get; set; }
        [FirestoreProperty]
        public string district { get; set; }
        [FirestoreProperty]
        public string postalCode { get; set; }
        [FirestoreProperty]
        public string region { get; set; }
        [FirestoreProperty]
        public string street { get; set; }
    }
}

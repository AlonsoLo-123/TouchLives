using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchLives.Modelos
{
    class ModelLogin
    {
    }

    [FirestoreData]
    public class ModStateData
    {
        //Datos de la ciudad
        [FirestoreProperty]
        public GeoPoint position { get; set; }
        [FirestoreProperty]
        public string Id { get; set; }
        [FirestoreProperty]
        public bool active { get; set; }
    }
    [FirestoreData]
    public class ModStateCB
    {
        //Municipio y Estado
        [FirestoreProperty]
        public string state { get; set; }
        [FirestoreProperty]
        public string city { get; set; }
    }
}

using Google.Cloud.Firestore;
using System;

namespace TouchLives
{
    public class Fire
    {
        public static void Iniciar()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Conexion/touchlives-2020cj-firebase-adminsdk-hkyjn-f3f5615a27.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            Console.WriteLine("Conexión");
        }

        public static FirestoreDb DB()
        {
            FirestoreDb db = FirestoreDb.Create("touchlives-2020cj");
            return db;
        }
        
    }


}

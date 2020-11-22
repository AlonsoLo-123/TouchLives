using GMap.NET.WindowsForms;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchLives.Map;
using TouchLives.Modelos;

namespace TouchLives.CRUD
{
    public class ReadState
    {
        public static FirestoreDb data = Fire.DB();

        /// Read States
        ///
        public void StateRead_DataState(ComboBox CBState)
        {
            string state;
            System.IO.StreamReader Estados =
                new System.IO.StreamReader(@"Data\Estados.txt");
            while ((state = Estados.ReadLine()) != null)
            {
                CBState.Items.Add(state);
            }
            Estados.Close();
        }
        ///
        /// Read States

        /// Obtener todos las cities Activas y retornarlas (State ID.txt)
        /// 
        public async Task<List<ModStateData>> StateRead_ActiveCity(string dstate)
        {
            List<ModStateData> DatosCity = new List<ModStateData>();
            CollectionReference DRCity = data.Collection("state").Document(dstate).Collection("city");
            Query QId = DRCity.WhereEqualTo("active",true);
            QuerySnapshot QSCity = await QId.GetSnapshotAsync();
            foreach (DocumentSnapshot DataCity in QSCity)
            {
                ModStateData City = DataCity.ConvertTo<ModStateData>();
                DatosCity.Add(City);
            }
            return DatosCity;
        }
        ///
        /// Obtener todos las cities Activas y retornarlas (State ID.txt)
    }

    /// ___________________________________________________________________________________________________________________
    public class UsersAlerts
    {

        public static FirestoreDb data = Fire.DB();

        /// Listener for User`s Nortifications (Server ID)
        /// 
        public void ListenerUsersNoti(ModStateData Server, DataGridView TablaN, DataGridView TablaAll, GMapControl GMC)
        {
            Query QUser = data.Collection("usuarios").WhereEqualTo("noti", Server.Id);
            FirestoreChangeListener FCLUser;
            FCLUser = QUser.Listen(ListenerUserAlert =>
            {
                ClearTables(TablaN,TablaAll);
                foreach (DocumentSnapshot UserData in ListenerUserAlert.Documents)
                {
                    ModTablaUser Data = UserData.ConvertTo<ModTablaUser>();
                    AddUsersInTables(Data,TablaN,TablaAll);
                    GetAlertActives(Data.Id);
                }
            });
        }
        /// 
        /// Listener for User`s Nortifications (Server ID)

        /// Invocar y añadir a tablas
        /// 
        public void AddUsersInTables(ModTablaUser UserData, DataGridView TablaNot, DataGridView TablaAll)
        {
            if (TablaNot.InvokeRequired)
                TablaNot.Invoke((Action)(() => TablaNot.Rows.Add(UserData.nombre)));
            else
                TablaNot.Invoke((Action)(() => TablaNot.Rows.Add(UserData.nombre)));

            if (TablaAll.InvokeRequired)
                TablaAll.Invoke((Action)(() => TablaAll.Rows.Add(UserData.Id, UserData.nombre + " " + UserData.ap_paterno + " " + UserData.ap_materno, UserData.telefono)));
            else
                TablaAll.Invoke((Action)(() => TablaAll.Rows.Add(UserData.Id, UserData.nombre + " " + UserData.ap_paterno + " " + UserData.ap_materno, UserData.telefono)));
        }
        ///
        /// Invocar y añadir a tablas
        
        /// Invocar y limpiar tablas
        /// 
        public void ClearTables(DataGridView TablaNot, DataGridView TablaAll)
        {
            if (TablaNot.InvokeRequired) 
                TablaNot.Invoke((Action)(() => TablaNot.Rows.Clear()));
            else
                TablaNot.Invoke((Action)(() => TablaNot.Rows.Clear()));

            if (TablaAll.InvokeRequired)
                TablaAll.Invoke((Action)(() => TablaAll.Rows.Clear()));
             else
                TablaAll.Invoke((Action)(() => TablaAll.Rows.Clear()));
        }
        /// 
        /// Invocar y limpiar tablas
        
        public void GetDataAlerts(DataGridView TablaAlert, ModUserAlertsId Alert)
        {
            //GMC.Overlays.Add(Gmap.CreateMapMaker(Alert, UserDataNoti));
        }

        public List<ModUserAlertsId> GetAlertActives (String id)
        {
            List<ModUserAlertsId> AlertasDatos = new List<ModUserAlertsId>();
            Query QAlert = data.Collection("usuarios").Document(id).Collection("alertas").WhereEqualTo("active", true);
            FirestoreChangeListener FCLAlert;
            FCLAlert = QAlert.Listen(ListenAlerts =>
            {
                foreach (DocumentSnapshot AlertData in ListenAlerts.Documents)
                {
                    ModUserAlertsId Alert = AlertData.ConvertTo<ModUserAlertsId>();
                    AlertasDatos.Add(Alert);
                }
            });
            return AlertasDatos;
        }

        /// Obtener y retornar todas las Alertas de UID
        /// 
        public async Task<List<ModUserAlertsId>> GetAlertAll(String id)
        {
            List<ModUserAlertsId> AlertasDatos = new List<ModUserAlertsId>();
            List<String> Ids = new List<string>();
            Query QAlert = data.Collection("usuarios").Document(id).Collection("alertas");
            QuerySnapshot QSAlert = await QAlert.GetSnapshotAsync();
                
            foreach (DocumentSnapshot AlertData in QSAlert.Documents)
            {
                ModUserAlertsId Alert = AlertData.ConvertTo<ModUserAlertsId>();
                Alert.Id = AlertData.Id;
                AlertasDatos.Add(Alert);
            }
            
            return AlertasDatos;
        }
        /// 
        /// Obtener y retornar todas las Alertas de UID
        

        //private async void AllUser()
        //{
        //    int row = 0;
        //    CollectionReference users = data.Collection("usuarios");
        //    QuerySnapshot SnapshotUsers;
        //    SnapshotUsers = await users.GetSnapshotAsync();
        //    Tabla.Rows.Clear();
        //    foreach (DocumentSnapshot AllUsers in SnapshotUsers.Documents)
        //    {
        //        Console.WriteLine(AllUsers.Id);
        //        ModTablaUser UserDataAll = AllUsers.ConvertTo<ModTablaUser>();
        //        Tabla.Rows.Add(UserDataAll.nombre, UserDataAll.ap_paterno,
        //            UserDataAll.ap_materno, UserDataAll.telefono, UserDataAll.email);
        //        if (UserDataAll.noti == Server.Id)
        //            Tabla.Rows[row].DefaultCellStyle.ForeColor = Color.Red;
        //        else
        //            Tabla.Rows[row].DefaultCellStyle.ForeColor = Color.Black;
        //        row++;
        //    }
        //}
    }
}

using GMap.NET.WindowsForms;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchLives.Map;
using TouchLives.Modelos;

namespace TouchLives.CRUD
{
    public class ReadState
    {
        public static FirestoreDb data = Fire.DB();
        //Read states
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
        //Read Cities
        public async Task<List<ModStateData>> StateRead_ActiveCity(string cstate, string dstate, string ccity)
        {
            List<ModStateData> DatosCity = new List<ModStateData>();
            CollectionReference DRCity = data.Collection(cstate).Document(dstate).Collection(ccity);
            Query QId = DRCity.WhereEqualTo("active",true);
            QuerySnapshot QSCity = await QId.GetSnapshotAsync();
            foreach (DocumentSnapshot DataCity in QSCity)
            {
                ModStateData City = DataCity.ConvertTo<ModStateData>();
                DatosCity.Add(City);
            }
            return DatosCity;
        }
    }
    public class UsersAlerts
    {
        Maps Gmap = new Maps();

        public static FirestoreDb data = Fire.DB();
        //Listener for Nortifications
        public void ListenerUsersNoti(ModStateData Server, DataGridView TablaN, DataGridView TablaAll, GMapControl GMC)
        {
            Query QUser = data.Collection("usuarios").WhereEqualTo("noti", Server.Id);
            FirestoreChangeListener FCLUser;
            FCLUser = QUser.Listen(ListenerUserAlert =>
            {
                ClearRowsNot(TablaN,TablaAll);
                foreach (DocumentSnapshot UserData in ListenerUserAlert.Documents)
                {
                    ModTablaUser Data = UserData.ConvertTo<ModTablaUser>();
                    AddUsersInTableNot(Data, TablaN,TablaAll);
                    GetAlert(Data, GMC);
                }
            });
        }

        public void AddUsersInTableNot(ModTablaUser UserData, DataGridView TablaNot, DataGridView TablaAll)
        {
            if (TablaNot.InvokeRequired)
                TablaNot.Invoke((Action)(() => TablaNot.Rows.Add(UserData.nombre)));
            else
                TablaNot.Invoke((Action)(() => TablaNot.Rows.Add(UserData.nombre)));

            if (TablaAll.InvokeRequired)
                TablaAll.Invoke((Action)(() => TablaAll.Rows.Add(UserData.nombre, UserData.ap_paterno, UserData.ap_materno, UserData.telefono)));
            else
                TablaAll.Invoke((Action)(() => TablaAll.Rows.Add(UserData.nombre, UserData.ap_paterno, UserData.ap_materno, UserData.telefono)));
        }

        public void ClearRowsNot(DataGridView TablaNot, DataGridView TablaAll)
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

        public void GetAlert (ModTablaUser UserDataNoti, GMapControl GMC)
        {
            Query QAlert = data.Collection("usuarios").Document(UserDataNoti.Id).Collection("alertas").WhereEqualTo("active", true);
            FirestoreChangeListener FCLAlert;
            FCLAlert = QAlert.Listen(ListenAlerts =>
            {
                foreach (DocumentSnapshot AlertData in ListenAlerts.Documents)
                {
                    ModUserAlerts Alert = AlertData.ConvertTo<ModUserAlerts>();
                    GMC.Overlays.Add(Gmap.CreateMapMaker(Alert, UserDataNoti));
                }
            });
        }
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

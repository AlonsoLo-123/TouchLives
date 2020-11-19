using Google.Cloud.Firestore;
using System;
using System.Drawing;
using System.Windows.Forms;
using TouchLives.Map;
using TouchLives.BarraSup;
using TouchLives.Modelos;
using TouchLives.CRUD;
using System.Collections.Generic;

namespace TouchLives
{
    public partial class Principal : Form
    {
        Maps Gmap = new Maps();
        BarSup Bar = new BarSup();
        UsersAlerts UserA = new UsersAlerts();
        private static ModStateData Server = new ModStateData();


        public Principal(ModStateData Serv)
        {
            InitializeComponent();
            Server = Serv;
        }
        
        private void TouchLives_Load(object sender, EventArgs e)
        {
            Gmap.DrawMap(GMapAlert, Server.position);
            UserA.ListenerUsersNoti(Server,TablaNot,TablaAll,GMapAlert);
            LMun.Text = "Municipio: " + Server.Id;
        }

        private void MostrarT_Click(object sender, EventArgs e)
        {
            //UserA.AllUser();
        }

        private void MostrarH_Click(object sender, EventArgs e)
        {
            //Gmap.CreateMapMaker(GMapAlert,position);
        }


        private void Tabla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }



        /// WinBar Events
        private void Close_Click(object sender, EventArgs e)
            {
                Bar.CloseForm();
            }
            private void Maximize_Click(object sender, EventArgs e)
            {
                Bar.MaxForm(this);
            }
            private void Minimize_Click(object sender, EventArgs e)
            {
                Bar.MinForm(this);
            }
            private void WinBar_MouseDown(object sender, MouseEventArgs e)
            {
                Bar.MDown(e.X,e.Y);
            }
            private void WinBar_MouseMove(object sender, MouseEventArgs e)
            {
                Bar.MMove(this,MousePosition.X, MousePosition.Y);
        }
            private void WinBar_MouseUp(object sender, MouseEventArgs e)
            {
                Bar.MUp();
            }


     

        private void BtnCenter_Click(object sender, EventArgs e)
        {
            Gmap.MapPosition(GMapAlert, Server.position);
        }

        bool IsSat;

        private void BtnSat_Click(object sender, EventArgs e)
        {
            if (IsSat)
                IsSat = Gmap.Map_DrawMap(GMapAlert);
            else
                IsSat = Gmap.Sat_DrawMap(GMapAlert);
        }

        private async void TablaAll_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String Id = TablaAll.CurrentRow.Cells[0].Value.ToString();
            String Nombre = TablaAll.CurrentRow.Cells[1].Value.ToString();

            Console.WriteLine(Id);
            TablaAlert.Rows.Clear();
            List<ModUserAlerts> AlertasDatos = new List<ModUserAlerts>(await UserA.GetAlertAll(Id));
            for (int i = 0; i < AlertasDatos.Count; i++)
            {
                TablaAlert.Rows.Add(AlertasDatos[i].active, AlertasDatos[i].date.ToDateTime(), AlertasDatos[i].sendLocation.district,
                    AlertasDatos[i].localizaction.Longitude, AlertasDatos[i].localizaction.Latitude);
            }
            LabelAlertas.Text = "Alertas de: " + Nombre;
        }

        private void TablaAlert_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Double Longitud =(Double) TablaAlert.CurrentRow.Cells[3].Value;
            Double Latitud =(Double) TablaAlert.CurrentRow.Cells[4].Value;

            GeoPoint GPAlert = new GeoPoint(Latitud, Longitud);
            Gmap.MapPosition(GMapAlert, GPAlert);
        }

        /// WinBar Events

    }
}

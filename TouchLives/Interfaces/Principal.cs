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
        
        
        /// WinBar Events
        /// 
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
        ///
        /// WinBar Events


        private void BtnCenter_Click(object sender, EventArgs e)
        {
            Gmap.MapPosition(GMapAlert, Server.position);
        }

        bool IsSat, PTHide;

        private void BtnSat_Click(object sender, EventArgs e)
        {
            if (IsSat)
                IsSat = Gmap.Map_DrawMap(GMapAlert);
            else
                IsSat = Gmap.Sat_DrawMap(GMapAlert);
        }

        /// Eventos Tabla de usuarios
        ///
        private async void TablaAll_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PBarLoading.Value = 1;
            PBarLoading.Step = 1;
            PBarLoading.Maximum = 3;
            
            String Id = TablaAll.CurrentRow.Cells[0].Value.ToString();
            String Nombre = TablaAll.CurrentRow.Cells[1].Value.ToString();
            
            TablaAlert.Rows.Clear();

            try
            {
                PBarLoading.PerformStep();

                List<ModUserAlertsId> AlertasDatos = new List<ModUserAlertsId>(await UserA.GetAlertAll(Id));
                foreach (var bike in AlertasDatos)
                {
                    Console.WriteLine(bike.active);
                }
                for (int i = 0; i < AlertasDatos.Count; i++)
                {
                    TablaAlert.Rows.Add(AlertasDatos[i].Id, AlertasDatos[i].active, AlertasDatos[i].date.ToDateTimeOffset().ToLocalTime().DateTime, AlertasDatos[i].sendLocation.district,
                        AlertasDatos[i].localizaction.Longitude, AlertasDatos[i].localizaction.Latitude);
                }
                LabelAlertas.Text = "Alertas de: " + Nombre;
            }
            catch
            {
                LabelAlertas.Text = "Error obteniendo datos...";
                PBarLoading.PerformStep();
            }

            if (TablaAlert.Rows.Count != 0)
                PBarLoading.PerformStep();
        }

        private void TablaAll_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String UId = TablaAll.CurrentRow.Cells[0].Value.ToString();
            LabelUID.Text = "UID: " + UId;
        }
        ///
        /// Eventos Tabla de usuarios
        
        private void TablaAlert_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Double Longitud =(Double) TablaAlert.CurrentRow.Cells[4].Value;
            Double Latitud =(Double) TablaAlert.CurrentRow.Cells[5].Value;

            GeoPoint GPAlert = new GeoPoint(Latitud, Longitud);
            Gmap.MapPosition(GMapAlert, GPAlert);
        }

        /// Timer Tiempo real
        /// 
        private void Timer_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = DateTime.Now.ToString("hh:mm:ss");
            _LabelDate.Text = DateTime.Now.ToShortDateString();
            //LabelDate.Text = DateTime.Now.ToLongDateString();
        }
        /// 
        /// Timer Tiempo real

        /// Eventos Botones de Alertas
        /// 
        private void MostrarMas_Click(object sender, EventArgs e)
        {
            if (TablaAlert.Rows.Count != 0)
            {
                String IdAlert = TablaAlert.CurrentRow.Cells[0].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione un alerta");

        }

        private void BtnDesactivarAll_Click(object sender, EventArgs e)
        {

        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {

        }

        private void BtnZoomOut_Click(object sender, EventArgs e)
        {
            if (GMapAlert.Zoom <= 20 && GMapAlert.Zoom > 10)
                GMapAlert.Zoom = GMapAlert.Zoom - 1;
        }

        private void BtnZoomIn_Click(object sender, EventArgs e)
        {
            if (GMapAlert.Zoom < 20 && GMapAlert.Zoom >= 10)
                GMapAlert.Zoom = GMapAlert.Zoom + 1;
        }



        ///
        /// Eventos Botones de Alertas


        /// Ocultar/Mostrar Tabla Usuarios y Alertas
        /// 
        private void BtnHidePT_Click_1(object sender, EventArgs e)
        {
            if (PTHide)
            {
                Pan_Tables_Alert_Info.Visible = true;
                Pan_TableUser_PBar.Visible = true;
                PTHide = false;
                BtnHidePT.BackgroundImage = Properties.Resources.HFalse;
            }
            else
            {
                Pan_Tables_Alert_Info.Visible = false;
                Pan_TableUser_PBar.Visible = false;
                PTHide = true;
                BtnHidePT.BackgroundImage = Properties.Resources.HTrue;
            }
        }
        ///
        /// Ocultar/Mostrar Tabla Usuarios y Alertas
    }
}

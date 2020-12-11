using Google.Cloud.Firestore;
using System;
using System.Drawing;
using System.Windows.Forms;
using TouchLives.Map;
using TouchLives.BarraSup;
using TouchLives.Modelos;
using TouchLives.CRUD;
using System.Collections.Generic;
using Google.Cloud.Storage.V1;
using TouchLives.Interfaces;

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
            LabelMun.Text = "Municipio: " + Server.Id;
        }
        

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
            
            string Id = TablaAll.CurrentRow.Cells[0].Value.ToString();
            string Nombre = TablaAll.CurrentRow.Cells[1].Value.ToString();
            LabelUID.Text = Id;

            TablaAlert.Rows.Clear();

            try
            {
                PBarLoading.PerformStep();

                List<ModUserAlertsId> AlertasDatos = new List<ModUserAlertsId>(await UserA.GetAlertAll(Id,CheckBAllAlerts.Checked));
                foreach (var Data in AlertasDatos)
                {
                    TablaAlert.Rows.Add(Data.Id, Data.active, Data.date.ToDateTimeOffset().ToLocalTime().DateTime,
                        Data.localizaction.Longitude, Data.localizaction.Latitude, Data.sendLocation.city, Data.sendLocation.district,
                        Data.sendLocation.postalCode, Data.sendLocation.street);
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
        ///
        /// Eventos Tabla de usuarios
        private void TablaAlert_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            double Longitud =(double) TablaAlert.CurrentRow.Cells[3].Value;
            double Latitud =(double) TablaAlert.CurrentRow.Cells[4].Value;

            GeoPoint GPAlert = new GeoPoint(Latitud, Longitud);
            Gmap.MapPosition(GMapAlert, GPAlert);

        }

        private void TablaAlert_CurrentCellChanged(object sender, EventArgs e)
        {
           
            if(TablaAlert.CurrentRow != null)
                PutDataUser();
        }

        public void PutDataUser()
        {
            LabelAID.Text = TablaAlert.CurrentRow.Cells[0].Value.ToString();
            labelActive.Text = (bool)TablaAlert.CurrentRow.Cells[1].Value ? "Activa" : "Desactivada";
            labelDate.Text = TablaAlert.CurrentRow.Cells[2].Value.ToString();
            labelLocalizaction.Text = TablaAlert.CurrentRow.Cells[3].Value.ToString();
            labelLocalizaction1.Text = TablaAlert.CurrentRow.Cells[4].Value.ToString();
            labelCity.Text = TablaAlert.CurrentRow.Cells[5].Value.ToString();
            labelDistrict.Text = TablaAlert.CurrentRow.Cells[6].Value.ToString();
            labelPostalCode.Text = TablaAlert.CurrentRow.Cells[7].Value.ToString();
            labelStreet.Text = TablaAlert.CurrentRow.Cells[8].Value.ToString();
        }


        private void PB_Close_MoreAlert_Click(object sender, EventArgs e)
        {
            CloseMoreFromAlert(false);
        }

        public void CloseMoreFromAlert(bool estado)
        {
            Pan_Audio.Visible = estado;
            Pan_Image.Visible = estado;
            PB_Close_MoreAlert.Visible = estado;
        }
        /// Eventos Botones de Alertas
        /// 
        private async void MostrarMas_Click(object sender, EventArgs e)
        {
            if (TablaAlert.Rows.Count != 0)
            {
                CloseMoreFromAlert(true);
                DownloadObject lol = new DownloadObject();
                string SPath = $"usuarios/{LabelUID.Text}/{LabelAID.Text}/image";
                CBImages.DataSource = lol.ListToDownload(SPath);
                //string IdAlert = TablaAlert.CurrentRow.Cells[0].Value.ToString();
                //ModUserAlertsId Alerta = new ModUserAlertsId();
                //Alerts _Alertas = new Alerts(LabelUID.Text, Alerta = await UserA.GetOnlyAlert(LabelUID.Text, IdAlert));
                //_Alertas.Show();
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


        /// Botones ZOOm Mapa
        /// 
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
        /// Botones ZOOm Mapa

        /// Timer Tiempo real
        /// 
        private void Timer_Tick(object sender, EventArgs e)
        {
            LabelTimeSystem.Text = DateTime.Now.ToString("hh:mm:ss");
            LabelDateSystem.Text = DateTime.Now.ToShortDateString();
            //LabelDate.Text = DateTime.Now.ToLongDateString();
        }
        /// 
        /// Timer Tiempo real
        /// 


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
            Bar.MDown(e.X, e.Y);
        }
        private void WinBar_MouseMove(object sender, MouseEventArgs e)
        {
            Bar.MMove(this, MousePosition.X, MousePosition.Y);
        }
        private void WinBar_MouseUp(object sender, MouseEventArgs e)
        {
            Bar.MUp();
        }
        ///
        /// WinBar Events

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bar.CloseForm();
        }
    }
}

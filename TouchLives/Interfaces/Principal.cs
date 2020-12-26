using Google.Cloud.Firestore;
using System;
using System.Drawing;
using System.Windows.Forms;
using TouchLives.Map;
using TouchLives.BarraSup;
using TouchLives.Modelos;
using TouchLives.CRUD;
using System.Collections.Generic;
using System.IO;
using TouchLives.Models;
using System.ComponentModel;
using TouchLives.Interfaces;
using System.Diagnostics;
using System.Reflection;
using System.Linq;
using System.Media;

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
        private async void TablaAll_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

                List<ModUserAlertsId> AlertasDatos = new List<ModUserAlertsId>(await UserA.GetAlertAll(Id, CheckBAllAlerts.Checked));
                foreach (var Data in AlertasDatos)
                {
                    TablaAlert.Rows.Add(Data.Id, Data.active, Data.date.ToDateTimeOffset().ToLocalTime().DateTime,
                        Data.localizaction.Longitude, Data.localizaction.Latitude, Data.sendLocation.city, Data.sendLocation.district,
                        Data.sendLocation.postalCode, Data.sendLocation.street);
                }
                TablaAlert.Sort(this.TablaAlert.Columns[2], ListSortDirection.Descending);
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
        List<ModelImage> DataImg = new List<ModelImage>();
        List<ModelImage> DataAud = new List<ModelImage>();
        string LocPath;
        DownloadObject DownObj = new DownloadObject();


        private async void Btn1(object sender, EventArgs e)
        {
            string BName = "touchlives-2020cj.appspot.com";

            if (TablaAlert.Rows.Count != 0)
            {
                labelInfoAudio.Text = "Cargando...";
                labelInfoAudio.ForeColor = Color.Yellow;

                LocPath = $"usuarios/{LabelUID.Text}/{LabelAID.Text}/audio/";
                DataAud = DownObj.ListToDownload(BName, LocPath);
                labelInfoAudioItems.Text = DataAud.Count.ToString();
                foreach (var ObjData in DataAud)
                {
                    CBAudio.Items.Add(await DownObj.DownloadObjectAsync(BName, LocPath, ObjData.Name));
                    if (CBAudio.Items.Count == 1)
                    {
                        labelInfoAudio.Text = "Seleccione un audio";
                        labelInfoAudio.ForeColor = Color.GreenYellow;
                        CBAudio.Enabled = true;
                    }
                }
                if (CBAudio.Items.Count < 1)
                {
                    labelInfoAudio.Text = "Sin audio aún";
                    labelInfoAudio.ForeColor = Color.Red;
                }
                //Btn1.Enabled = true;
            }
            else
                MessageBox.Show("Seleccione un alerta");
        }

        private async void MostrarMas_Click(object sender, EventArgs e)
        {
            string BName = "touchlives-2020cj.appspot.com";

            if (TablaAlert.Rows.Count != 0)
            {
                IniEvi();
                labelInfoImage.Text = "Cargando...";
                labelInfoImage.ForeColor = Color.Yellow;

                LocPath = $"usuarios/{LabelUID.Text}/{LabelAID.Text}/image/";
                DataImg = DownObj.ListToDownload(BName, LocPath);
                labelInfoImageItems.Text = DataImg.Count.ToString();
                foreach (var ObjData in DataImg)
                {
                    CBImages.Items.Add(await DownObj.DownloadObjectAsync(BName, LocPath, ObjData.Name));
                    if (CBImages.Items.Count == 1)
                    {
                        labelInfoImage.Text = "Seleccione una imagen";
                        labelInfoImage.ForeColor = Color.GreenYellow;
                        CBImages.Enabled = true;
                    }
                }
                if (CBImages.Items.Count < 1)
                {
                    labelInfoImage.Text = "Sin imagen aún";
                    labelInfoImage.ForeColor = Color.Red;
                }
                BtnMostrarMas.Enabled = true;
            }
            else
                MessageBox.Show("Seleccione un alerta");
        }

        private void IniEvi()
        {
            CBImages.Enabled = false;
            CBAudio.Enabled = false;
            BtnMostrarMas.Enabled = false;
            CBImages.Items.Clear();
            CBAudio.Items.Clear();
            PicBoxImageAlert.Image = null;
            BtnPlayEvi.Enabled = false;
            BtnPauseEvi.Enabled = false;
            CloseMoreFromAlert(true);
        }

        private void BtnDesactivarAll_Click(object sender, EventArgs e)
        {

        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {

        }

        SoundPlayer simpleSound = new SoundPlayer();

        private void CBAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string FullLPath = LocPath + CBAudio.Text;
                simpleSound.SoundLocation = FullLPath;
                simpleSound.LoadAsync();
                BtnPlayEvi.Enabled = true;

            }
            catch
            {
                labelInfoAudio.Text = "Error...";
            }

            int Indx = CBAudio.SelectedIndex;
            labelInfoAudio.Text = DataAud[Indx].Date.ToString();
        }

        private void BtnPlayEvi_Click(object sender, EventArgs e)
        {
            if (this.simpleSound.IsLoadCompleted)
            {
                this.simpleSound.PlaySync();
            }
        }

        private void BtnPauseEvi_Click(object sender, EventArgs e)
        {

        }

        private void CBImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string FullLPath = LocPath + CBImages.Text;
                using (FileStream fs = new System.IO.FileStream(FullLPath, FileMode.Open, FileAccess.Read))
                {
                    PicBoxImageAlert.Image = System.Drawing.Image.FromStream(fs);
                    fs.Close();
                }
            }
            catch
            {
                labelInfoImage.Text = "Error...";
            }

            int Indx = CBImages.SelectedIndex;
            labelInfoImage.Text = DataImg[Indx].Date.ToString();
        }

        private void PicBoxImageAlert_Click(object sender, EventArgs e)
        {
            if(CBImages.Text.Length != 0)
            {
                var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                string FullLPath = Path.Combine(outPutDirectory, LocPath + CBImages.Text);
                Console.WriteLine(FullLPath);
                Process p = new Process();
                p.StartInfo.FileName = FullLPath;
                p.Start();
            }
            
            //string FullLPath = Path + CBImages.Text;
            //ImgAlert ImageX = new ImgAlert(FullLPath);
            //ImageX.Show();
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
        private void Pan_WinBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Bar.MaxForm(this);
        }
        ///
        /// WinBar Events

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bar.CloseForm();
        }
    }
}

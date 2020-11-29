using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TouchLives.BarraSup;
using TouchLives.CRUD;
using TouchLives.Modelos;

namespace TouchLives
{
    public partial class State : Form
    {
        ReadState ReadState = new ReadState();
        BarSup Bar = new BarSup();
        List<ModStateData> AllDatosCity = new List<ModStateData>();
        
        public State()
        {
            InitializeComponent();
        }

        private void State_Load(object sender, EventArgs e)
        {
            ReadState.StateRead_DataState(this.CBState);
        }


        /// WinBar Events
        ///
        private void Icon_Close_Click(object sender, EventArgs e)
        {
            Bar.CloseForm();
        }

        private void Icon_Minimize_Click(object sender, EventArgs e)
        {
            Bar.MinForm(this);
        }

        private void WinBarLogin_MouseDown(object sender, MouseEventArgs e)
        {
            Bar.MDown(e.X, e.Y);
        }

        private void WinBarLogin_MouseUp(object sender, MouseEventArgs e)
        {
            Bar.MUp();
        }

        private void WinBarLogin_MouseMove(object sender, MouseEventArgs e)
        {
            Bar.MMove(this, MousePosition.X, MousePosition.Y);
        }
        ///
        /// WinBar Events


        private async void CBState_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            LCargando.Text = "Cargando...";
            LCargando.ForeColor = Color.Yellow;
            try
            {
                SetData(AllDatosCity = await ReadState.StateRead_ActiveCity(CBState.Text));
            }
            catch
            {
                LCargando.Text = "Error de conexión";
                LCargando.ForeColor = Color.Red;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (CBState.Text.Length != 0 && CBCity.Text.Length != 0)
            {
                Login login = new Login(GetCity(), GetCBData());
                login.Show();
                this.Hide();
            }
            else
            {
                LCargando.Text = "Verifique los datos";
                LCargando.ForeColor = Color.Red;
            }
        }

        private void SetData (List<ModStateData> DatosCity)
        {
            CBCity.Items.Clear();
            foreach (ModStateData data in DatosCity)
            {
                CBCity.Items.Add(data.Id);
            }
            if (CBCity.Items.Count != 0)
            {
                LCargando.Text = "Datos para " + CBState.Text.ToString();
                LCargando.ForeColor = Color.GreenYellow;
                CBCity.Enabled = true;
            }
            else
            {
                LCargando.Text = "No hay datos para " + CBState.Text.ToString();
                LCargando.ForeColor = Color.Red;
                CBCity.Enabled = false;
            }
        }
        private ModStateData GetCity()
        {
            foreach (ModStateData data in AllDatosCity)
            {
                if (data.Id == CBCity.Text)
                    return data;
            }
        return null;
        }
        private ModStateCB GetCBData()
        {
            ModStateCB StateCity = new ModStateCB();
            StateCity.city = CBCity.Text;
            StateCity.state = CBState.Text;
            return StateCity;
        }

        
    }
}

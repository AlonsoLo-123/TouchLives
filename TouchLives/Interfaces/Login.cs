using Google.Cloud.Firestore;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchLives.BarraSup;
using TouchLives.Modelos;

namespace TouchLives
{
    public partial class Login : Form
    {
        public static FirestoreDb data = Fire.DB();
        BarSup Bar = new BarSup();
        private ModStateData ServerData = new ModStateData();
        private static ModStateCB Server = new ModStateCB();

        public Login(ModStateData estado, ModStateCB StateCity)
        {
            InitializeComponent();
            ServerData = estado;
            Server = StateCity;
        }


        private async void BtnEnter_Click(object sender, EventArgs e)
        {
            LCargando.Text = "       Cargando...";
            LCargando.ForeColor = Color.GreenYellow;
            if (TBUser.TextLength != 0 && TBPassword.TextLength != 0)
            {
                if(await ValUser(TBUser.Text, TBPassword.Text))
                {
                    this.Hide();
                    Principal Princ = new Principal(ServerData);
                    Princ.Show();
                }
                else
                {
                    LCargando.Text = "   Error al acceder\nVerifique sus datos";
                    LCargando.ForeColor = Color.Red;
                }
            }
            else
            {
                LCargando.Text = "   Error al acceder\nVerifique sus datos";
                LCargando.ForeColor = Color.Red;
            }
            
        }


        private void Login_Load(object sender, EventArgs e)
        {
            LStateCity.Text = "Estado: "+ Server.state + "\nMunicipio: " + Server.city;
        }

        
       
        private static async Task<bool> ValUser(string user, string key)
        {
            CollectionReference CRVU = data.Collection("state").Document(Server.state).Collection("city").Document(Server.city).Collection("admin");
            Query QVU = CRVU.WhereEqualTo("user", user).WhereEqualTo("key", key);
            QuerySnapshot QSVU = await QVU.GetSnapshotAsync();
            foreach (DocumentSnapshot VUExist in QSVU.Documents)
            {
                if (VUExist.Exists)
                    return true;
            }
            return false;
        }
        

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            State state = new State();
            state.Show();
        }

        /// WinBar Events
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
        
        /// WinBar Events





    }
}

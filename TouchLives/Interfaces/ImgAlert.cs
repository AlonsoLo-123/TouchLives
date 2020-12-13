using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchLives.BarraSup;

namespace TouchLives.Interfaces
{
    public partial class ImgAlert : Form
    {
        BarSup Bar = new BarSup();
        string Fullpath;

        public ImgAlert(string image)
        {
            InitializeComponent();
            Fullpath = image;
        }
        private void PBoxImage_Paint(object sender, PaintEventArgs e)
        {
            LabelImage.Text = Path.GetFileName(Fullpath);
            ShowImages(Fullpath);
        }

        private void ShowImages(string LocalPath)
        {
            using (FileStream fs = new System.IO.FileStream(LocalPath, FileMode.Open, FileAccess.Read))
            {
                PBoxImage.Image = Image.FromStream(fs);
                fs.Close();
            }
        }

        /// WinBar Events
        /// 
        private void Icon_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Icon_Maximize_Click(object sender, EventArgs e)
        {
            Bar.MaxForm(this);
        }
        private void Icon_Minimize_Click(object sender, EventArgs e)
        {
            Bar.MinForm(this);
        }
        private void Pan_WinBar_MouseDown(object sender, MouseEventArgs e)
        {
            Bar.MDown(e.X, e.Y);
        }
        private void Pan_WinBar_MouseMove(object sender, MouseEventArgs e)
        {
            Bar.MMove(this, MousePosition.X, MousePosition.Y);
        }
        private void Pan_WinBar_MouseUp(object sender, MouseEventArgs e)
        {
            Bar.MUp();
        }
        private void ImgAlert_Load(object sender, EventArgs e)
        {
            Bar.MaxForm(this);
        }

        ///
        /// WinBar Events
    }
}

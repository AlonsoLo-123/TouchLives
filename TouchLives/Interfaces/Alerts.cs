using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Storage;
using Google.Apis.Download;
using Google.Apis.Upload;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using TouchLives.CRUD;
using System.IO;
using System.Threading;
using System.Security.AccessControl;
using TouchLives.BarraSup;

namespace TouchLives.Interfaces
{
    public partial class Alerts : Form
    {
        BarSup Bar = new BarSup();
        StorageClient Storage = StorageClient.Create();
        string BName = "touchlives-2020cj.appspot.com";

        GSorage GCS = new GSorage();

        public Alerts(string uid, ModUserAlertsId aid)
        {
            InitializeComponent();
            LabelUID.Text = uid;
            LabelAID.Text = aid.Id;
        }


        private void Alerts_Load(object sender, EventArgs e)
        {
            string SPath = $"usuarios/{LabelUID.Text}/{LabelAID.Text}/image";
            string LPath = $"Archives/usuarios/{LabelUID.Text}/{LabelAID.Text}/image/";

            ListToDownloadAndDoit(SPath, LPath);
        }

        public async void ListToDownloadAndDoit(string SPath, string LPath)
        {
            try
            {
                DirectoryInfo di = Directory.CreateDirectory(LPath);

                foreach (var storageObject in Storage.ListObjects(BName, SPath))
                {
                    string FullPath = storageObject.Name;
                    Console.WriteLine(FullPath);
                    if (!FullPath.EndsWith("/"))
                        await DownloadObjectAsync(BName, FullPath, LPath);
                }
                // Delete the directory.
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception x)
            {
                Console.WriteLine("Error: {0}", x.ToString());
            }
            finally { }
        }


        private async Task DownloadObjectAsync(string bucketName, string FullPath, string localPath)
        {
            localPath = localPath + Path.GetFileName(FullPath);
            Console.WriteLine(localPath);

            using (var SteamFilePath = File.Create(localPath))
            {
                await Storage.DownloadObjectAsync(bucketName, FullPath, SteamFilePath);
            }
            ShowImages(localPath);
            Console.WriteLine($"downloaded {FullPath} to {localPath}.");
        }


        private void ShowImages(string LocalPath)
        {
            using (FileStream fs = new System.IO.FileStream(LocalPath, FileMode.Open, FileAccess.Read))
            {
                pictureBox1.Image = Image.FromStream(fs);
                fs.Close();
            }
        }


        /// WinBar Events
        /// 
        private void Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

    }
}

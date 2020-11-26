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

namespace TouchLives.Interfaces
{
    public partial class Alerts : Form
    {
        StorageClient Storage = StorageClient.Create();
        string BName = "touchlives-2020cj.appspot.com";

        GSorage GCS = new GSorage();
        string UID,AID;
        
        public Alerts(string uid, string aid)
        {
            InitializeComponent();
            UID = uid;
            AID = aid;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            string path = "usuarios/" + UID + "/" + AID + "/" + "image" + "/";
            
            foreach (var storageObject in Storage.ListObjects(BName, path))
            {
                dlg.FileName = storageObject.Name;

                string Lpath = @"Archives";
                DownloadObject(BName, dlg.FileName, Lpath);
            }

            //FileStream fs = new System.IO.FileStream(@"Archives\a.bmp", FileMode.Open, FileAccess.Read);
            //pictureBox1.Image = Image.FromStream(fs);
            //fs.Close();
            //var token = new CancellationTokenSource().Token;

            //    using (var fileStream = File.Create(dlg.FileName))
            //    {

            //        var downloadObjectOptions = new DownloadObjectOptions
            //        {
            //            ChunkSize = UploadObjectOptions.MinimumChunkSize
            //        };
            //        var progressReporter = new Progress<IDownloadProgress>();
            //        await Storage.DownloadObjectAsync(BName, Path.GetFileName("Archives"), fileStream, downloadObjectOptions, token, progress: progressReporter).ConfigureAwait(true);
            //    }


        }

        private void Alerts_Load(object sender, EventArgs e)
        {
            GCS.ListArchives(UID,AID,"image");
        }



        private void DownloadObject(string bucketName, string objectName,
            string localPath)
        {
            localPath = localPath +"/"+ Path.GetFileName(objectName);
            using (var outputFile = File.OpenWrite(localPath))
            {
                Storage.DownloadObject(bucketName, objectName, outputFile);
            }
            Console.WriteLine($"downloaded {objectName} to {localPath}.");
        }
    }
}

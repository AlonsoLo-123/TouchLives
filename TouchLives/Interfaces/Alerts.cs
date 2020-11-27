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

namespace TouchLives.Interfaces
{
    public partial class Alerts : Form
    {
        StorageClient Storage = StorageClient.Create();
        string BName = "touchlives-2020cj.appspot.com";

        GSorage GCS = new GSorage();

        public Alerts(string uid, string aid)
        {
            InitializeComponent();
            LabelUID.Text = uid;
            LabelAID.Text = aid;
        }

        public async void button1_Click(object sender, EventArgs e)
        {
            string ObjRoute;
            var ServObjPath =  $"usuarios/{LabelUID.Text}/{LabelAID.Text}/image";
            
            string LPath = $"Archives/usuarios/{LabelUID.Text}/{LabelAID.Text}/image";

            try
            {
                if (Directory.Exists(LPath))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }
                
                DirectoryInfo di = Directory.CreateDirectory(LPath);

                DirectorySecurity dSecurity = di.GetAccessControl();

                AuthorizationRuleCollection acl = dSecurity.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));

                foreach (var storageObject in Storage.ListObjects(BName, ServObjPath))
                {
                    ObjRoute = storageObject.Name;
                    Console.WriteLine(ObjRoute);
                    if (!ObjRoute.EndsWith("/"))
                        DownloadObject(BName, ObjRoute, LPath);
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


        private void DownloadObject(string bucketName, string objectName,
            string localPath)
        {
            localPath = localPath ?? Path.GetFileName(objectName);
            Console.WriteLine(localPath);
            using (var outputFile = File.OpenWrite(localPath))
            {
                Storage.DownloadObject(bucketName, objectName, outputFile);
            }
            Console.WriteLine($"downloaded {objectName} to {localPath}.");
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


        private void Alerts_Load(object sender, EventArgs e)
        {
            //GCS.ListArchives(UID,AID,"image");
        }



        
    }
}

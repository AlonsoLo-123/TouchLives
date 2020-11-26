using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TouchLives.CRUD
{
    class GSorage
    {
        string BName = "touchlives-2020cj.appspot.com";
        StorageClient Storage = StorageClient.Create();

        private void ListBuckets()
        {
            //Storage.
        }
        public void ListArchives(string UID, string AID, string AoI)
        {
            //string path = "usuarios/" + UID + "/" + AID + "/" + AoI + "/";
            //foreach (var storageObject in Storage.ListObjects(BName, path))
            //{
            //    var ax = File.Create("Archives").IsAsync;
            //    Storage.DownloadObjectAsync(BName,storageObject.Name,ax);

            //}
            //Console.WriteLine(path);

        }

        //private void DownloadObject()
        //{
        //    string dlg = "Archives";
        //    if (dlg.ShowDialog() == DialogResult.OK)
        //    {
        //        var token = new CancellationTokenSource().Token;

        //        using (var fileStream = File.Create(dlg.FileName))
        //        {
        //            progressBar1.Maximum = int.Parse(lbl_byte.Text);

        //            var downloadObjectOptions = new DownloadObjectOptions
        //            {
        //                ChunkSize = UploadObjectOptions.MinimumChunkSize
        //            };
        //            var progressReporter = new Progress<IDownloadProgress>(OnDownloadProgress);
        //            await storageClient.DownloadObjectAsync(bucketName, Path.GetFileName(dlg.FileName), fileStream, downloadObjectOptions, token, progress: progressReporter).ConfigureAwait(true);
        //        }
        //    }
        //}

    }

    
}

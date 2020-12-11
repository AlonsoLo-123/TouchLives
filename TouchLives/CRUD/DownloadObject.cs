using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchLives.CRUD
{
    class DownloadObject
    {
        string BName = "touchlives-2020cj.appspot.com";
        
        StorageClient Storage = StorageClient.Create();

        public DirectoryInfo CreateDirectory(string LPath)
        {
            DirectoryInfo di = Directory.CreateDirectory(LPath);
            return di;
        }
        public void DeleteDirectory(DirectoryInfo di)
        {
            di.Delete();
            Console.WriteLine("El directorio :" + di.FullName + " ah sido borrado");
        }
        public List<string> ListToDownload(string SPath)
        {
            List<string> ObjList = new List<string>();
            try
            {
                foreach (var storageObject in Storage.ListObjects(BName, SPath))
                {
                    string FullPath = storageObject.Name;
                    Console.WriteLine(FullPath);
                    if (!FullPath.EndsWith("/"))
                        ObjList.Add(FullPath);
                        //await DownloadObjectAsync(BName, FullPath, LPath);
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("Error: {0}", x.ToString());
            }
            finally { }

            return ObjList;
        }

        //private async Task DownloadObjectAsync(string bucketName, string FullPath, string localPath)
        //{
        //    string ObjName = Path.GetFileName(FullPath);
        //    CBImages.Items.Add(ObjName);
        //    localPath = localPath + ObjName;
        //    Console.WriteLine(localPath);

        //    using (var SteamFilePath = File.Create(localPath))
        //    {
        //        await Storage.DownloadObjectAsync(bucketName, FullPath, SteamFilePath);
        //    }
        //    ShowImages(localPath);
        //    Console.WriteLine($"downloaded {FullPath} to {localPath}.");
        //}

    }
}

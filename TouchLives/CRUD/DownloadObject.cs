using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchLives.Models;

namespace TouchLives.CRUD
{
    class DownloadObject
    {
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

        public List<ModelImage> ListToDownload(string BName, string SPath)
        {
            List<ModelImage> ObjList = new List<ModelImage>();
            foreach (var StorageObj in Storage.ListObjects(BName, SPath))
            {
                var SObjOne = new ModelImage();
                SObjOne.Date = (DateTime)StorageObj.TimeCreated;
                SObjOne.Size = (ulong)StorageObj.Size;
                SObjOne.Name = Path.GetFileName(StorageObj.Name);
                ObjList.Add(SObjOne);
            }
            return ObjList;
        }

        public async Task<string> DownloadObjectAsync(string BName, string Path, string Name)
        {
            CreateDirectory(Path);
            string FileDown = Path + Name;
            using (var SteamFilePath = File.Create(FileDown))
            {
                await Storage.DownloadObjectAsync(BName, FileDown, SteamFilePath);
            }
            return Name;
        }


    }
}

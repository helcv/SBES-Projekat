using Common;
using SecurityManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    internal class FileSystemManagerService : IFileSystemManager
    {
        private string currentPath = Path.Combine(Directory.GetCurrentDirectory(), "root");
        public bool CreateFile(string filename, string fileContent)
        {
            throw new NotImplementedException();

        }
      
        public bool CreateFolder(string folderName)
        {
            throw new NotImplementedException();

        }

        public bool DeleteFile(string filename, bool isFile)
        {
            throw new NotImplementedException();

        }

        public bool MoveFile(string filename, string pathToFolder, bool isFile)
        {
            throw new NotImplementedException();
        }


        public string ReadFile(string filename)
        {
            throw new NotImplementedException();

        }
        public bool RenameFileOrFolder(string oldName, string newName, bool isFile)
        {
            throw new NotImplementedException();
        }

      
        public string ShowFolder(string filename)
        {
            throw new NotImplementedException();
        }

       
    }
}

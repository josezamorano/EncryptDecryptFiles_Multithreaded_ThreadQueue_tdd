using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEncryptDecrypt.Utils.Interfaces
{
    public interface IDirectoryProvider
    {
        void ResolveDirectoryIfNoExists(string filePath);

        string[] GetFilesFromDirectory(string directory);
        
        string[] GetAllDirectoriesFromDirectory(string directory);

        bool DirectoryExists(string directory);

        DirectoryInfo CreateDirectory(string directory);

    }
}

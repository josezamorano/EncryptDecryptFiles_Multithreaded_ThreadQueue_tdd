using FileEncryptDecrypt.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEncryptDecryptTests.MockingClasses
{
    //This is an alternative Implementation to the Nuget Package MOQ
    public class Mock_DirectoryProvider : IDirectoryProvider
    {
        public void ResolveDirectoryIfNoExists(string filePath)
        {
            //Mocking method
        }

        public string[] GetFilesFromDirectory(string directory)
        {
            if(string.IsNullOrEmpty(directory))
            {
                throw new ArgumentException("Invalid input", "directory");
            }
            string[] files = new string[2] { "test1.txt","test2.txt"};
            return files;
            
        }

        public string[] GetAllDirectoriesFromDirectory(string directory)
        {
            string[] directories = new string[0];// new string[2] { "/test1/videos", "/test2/videos" };
            return directories;
        }

        public bool DirectoryExists(string directory)
        {
            return true;
        }

        public DirectoryInfo CreateDirectory(string directory)
        {
           var dir = new DirectoryInfo(directory);
            return dir;
        }
    }
}

using FileEncryptDecrypt.Services.Enumerations;
using FileEncryptDecrypt.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEncryptDecryptTests.MockingClasses
{
    public class Mock_FileService : IFileService
    {
        public string CreateCipherFileName(string originalDirectory, string fullPathOriginalFile, CipherState cipherState)
        {
            throw new NotImplementedException();
        }

        public string CreateCipherFolderName(string originalDirectory, CipherState cipherState)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllFilesInDirectory(string directory)
        {
            return new List<string> { "/test/file1.txt", "/test/file2.txt" };
        }

        public string RemoveCipherSuffix(string fullPathFileName)
        {
            throw new NotImplementedException();
        }
    }
}

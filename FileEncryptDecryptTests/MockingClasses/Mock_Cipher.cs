using FileEncryptDecrypt.Utils.Interfaces;
using FileEncryptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEncryptDecryptTests.MockingClasses
{
    public class Mock_Cipher : ICipher
    {
        public string DecryptFile(string inFile, string outFile, string password, Form1.ProgressCallback decryptionProgressCallback)
        {
            throw new NotImplementedException();
        }

        public string EncryptFile(string inFile, string outFile, string password, Form1.ProgressCallback callback)
        {
            throw new NotImplementedException();
        }
    }
}

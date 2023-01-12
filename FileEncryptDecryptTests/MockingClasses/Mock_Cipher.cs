using FileEncryptDecrypt.DomainLayer.Models;
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
        public string DecryptFile(CipherActionInfo cipherActionInfo)
        {
            throw new NotImplementedException();
        }

        public string EncryptFile(CipherActionInfo cipherActionInfo)
        {
            throw new NotImplementedException();
        }
    }
}

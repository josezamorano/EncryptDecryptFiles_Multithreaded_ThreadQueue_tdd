using FileEncryptDecrypt.DomainLayer.Models;
using static FileEncryptor.Form1;

namespace FileEncryptDecrypt.Utils.Interfaces
{
    public interface ICipher
    {
        string EncryptFile(CipherActionInfo cipherActionInfo);

        string DecryptFile(CipherActionInfo cipherActionInfo);

    }
}

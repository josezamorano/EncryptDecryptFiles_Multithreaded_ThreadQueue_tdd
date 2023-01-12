using static FileEncryptor.Form1;

namespace FileEncryptDecrypt.Utils.Interfaces
{
    public interface ICipher
    {
        string EncryptFile(string inFile, string outFile, string password, ProgressCallback callback);

        string DecryptFile(string inFile, string outFile, string password, ProgressCallback decryptionProgressCallback);

    }
}

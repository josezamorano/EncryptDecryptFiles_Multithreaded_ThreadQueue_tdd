using FileEncryptDecrypt.DomainLayer.Models;

namespace FileEncryptDecrypt.Utils.Interfaces
{
    public interface ICryptographyManager
    {
        FolderContentInfo GetAllFiles(string folder);
        void CipherProcessAllFilesThread(CipherInvocationInfo cipherInvocationInfo);
    }
}

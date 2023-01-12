using FileEncryptDecrypt.Utils.Interfaces;

namespace FileEncryptDecrypt.DataAccessLayer.IOFiles
{
    public class FileProvider : IFileProvider
    {

        public FileStream FileOpenRead(string fullFilePath)
        {
           return  File.OpenRead(fullFilePath);
        }

        public FileStream FileOpenWrite(string fullFilePath)
        {
            return File.OpenWrite(fullFilePath);
        }
    }
}

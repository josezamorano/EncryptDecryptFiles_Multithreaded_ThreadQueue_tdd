using FileEncryptDecrypt.Utils.Interfaces;

namespace FileEncryptDecryptTests.MockingClasses
{
    public class Mock_ThreadQueue : IThreadQueue
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void EnqueueTask(Action task)
        {
            throw new NotImplementedException();
        }
    }
}

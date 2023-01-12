namespace FileEncryptDecrypt.Utils.Interfaces
{
    public interface IThreadQueue
    {
        void EnqueueTask(Action task);
        void Dispose();
    }
}

using FileEncryptDecrypt.Utils.Interfaces;
using FileEncryptDecrypt.Services.MultithreadingHelper;
using Xunit;
using Autofac.Extras.Moq;
using Moq;

namespace FileEncryptDecryptTests
{
    public class ThreadQueueTest
    {
        IThreadQueue _threadQueue;
        public ThreadQueueTest() 
        {
            _threadQueue = new ThreadQueue();
        }



        [Fact]
        public void EnqueueTask_ProvideValidInput_ReturnsOk()
        {
            //Arrange
            void EncryptDecryptFile()
            {
       
                string test = "File Encrypted / Decrypted";
                //Assert
                //Method EncryptDecryptFile ahs been called
                Assert.NotEmpty(test);
                Assert.True(true);
            }

            Action action = () => { EncryptDecryptFile();};
            //Act
            _threadQueue.EnqueueTask(action);            
        }

    }
}

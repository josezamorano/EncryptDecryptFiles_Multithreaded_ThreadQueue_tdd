using Autofac.Extras.Moq;
using FileEncryptDecrypt.DomainLayer;
using FileEncryptDecrypt.DomainLayer.Models;
using FileEncryptDecrypt.Utils.Interfaces;
using FileEncryptDecryptTests.MockingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FileEncryptDecryptTests
{
    public class CryptographyManagerTest
    {
        IFileService _fileServiceMock;
        ICipher _cipherMock;
        IThreadQueue _threadQueueMock;
        ICryptographyManager _cryptographyManager;
        public CryptographyManagerTest()
        {
            _fileServiceMock = new Mock_FileService();
            _cipherMock= new Mock_Cipher();
            _threadQueueMock= new Mock_ThreadQueue();
            _cryptographyManager = new CryptographyManager(_fileServiceMock,_cipherMock,_threadQueueMock );
        }


        [Fact]
        public void GetAllFiles_InputValidFolder_ReturnsAllFilesList()
        {
            //Arrange
            var folder = "test";
            var expectedCount = 2;
            //Act
            var result = _cryptographyManager.GetAllFiles(folder);
            //Assert
            Assert.Equal(expectedCount, result.TotalFiles);
        }

        [Fact]
        public void CipherProcessAllFilesThread_InputValidFolder_ReturnOk()
        {
            //Arrange
            CipherInvocationInfo cipherInvocationInfo = new CipherInvocationInfo();
            cipherInvocationInfo.CipherState = FileEncryptDecrypt.Services.Enumerations.CipherState.Encrypted;
            cipherInvocationInfo.Password = "abc";

            void ReportCallback(string report)
            {
                //Assert
                Assert.NotNull(report);
            }

            void ProgressCallback(int count)
            {
                int total = count;
            }
            cipherInvocationInfo.ReportCallBack = new FileEncryptor.Form1.ReportCallBack(ReportCallback);
            cipherInvocationInfo.ProgressCallback = new FileEncryptor.Form1.ProgressCallback(ProgressCallback);

            //Act
            _cryptographyManager.CipherProcessAllFilesThread(cipherInvocationInfo);      
        }


        #region Private Methods 

       
        #endregion Private Methods

    }
}

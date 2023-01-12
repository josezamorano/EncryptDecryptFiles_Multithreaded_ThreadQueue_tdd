using Autofac.Extras.Moq;
using FileEncryptDecrypt.DomainLayer;
using FileEncryptDecrypt.DomainLayer.Models;
using FileEncryptDecrypt.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static FileEncryptor.Form1;
using static System.Windows.Forms.Design.AxImporter;

namespace FileEncryptDecryptTests
{
    public class CipherTest
    {           
        private void ReportProgressCallback(int progress){}
        
        
        [Fact]
        public void EncryptFile_InputValidFiles_ReturnsEncryptedFileName()
        {
            FileStream fIn = null;
            FileStream fOut = null;
            SymmetricAlgorithm sma = Rijndael.Create();
            ProgressCallback callback = new ProgressCallback(ReportProgressCallback);
            string filePathRead = "test/Read";
            string filePathWrite = "test/Write";
            FileStream openReadFileStream = null;
            FileStream openWriteFileStream = null;


            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IFileProvider>()
                    .Setup(a => a.FileOpenRead(filePathRead))
                    .Returns(openReadFileStream);

                mock.Mock<IFileProvider>()
                    .Setup(b => b.FileOpenWrite("test"))
                    .Returns(openWriteFileStream);

                var cipherHelperMock = mock.Mock<ICipherHelper>();
                cipherHelperMock.Setup(c => c.ResolveEncryption(fIn, fOut, sma, callback))
                    .Returns(string.Empty);
               
                var cipher = mock.Create<Cipher>();
                var inFile = "test";
                var expected = "test";

                CipherActionInfo cipherActionInfo = new CipherActionInfo();
                cipherActionInfo.InFile = inFile;
                cipherActionInfo.OutFile = "test_Encrypt";
                cipherActionInfo.Password = "abc";
                cipherActionInfo.ProgressCallback= callback;

                var actual = cipher.EncryptFile(cipherActionInfo);

                Assert.Equal(expected, actual);

            }
        }

        [Fact]
        public void DecryptFile_InputValidFiles_ReturnsDecryptedFileName()
        {
            FileStream fIn = null;
            FileStream fOut = null;
            SymmetricAlgorithm sma = Rijndael.Create();
            ProgressCallback callback = new ProgressCallback(ReportProgressCallback);
            string filePathRead = "test/Read";
            string filePathWrite = "test/Write";
            FileStream openReadFileStream = null;
            FileStream openWriteFileStream = null;


            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IFileProvider>()
                    .Setup(a => a.FileOpenRead(filePathRead))
                    .Returns(openReadFileStream);

                mock.Mock<IFileProvider>()
                    .Setup(b => b.FileOpenWrite("test"))
                    .Returns(openWriteFileStream);

                var cipherHelperMock = mock.Mock<ICipherHelper>();
                cipherHelperMock.Setup(c => c.ResolveDecryption(fIn, fOut, sma, callback))
                    .Returns(string.Empty);

                var cipher = mock.Create<Cipher>();
                var inFile = "test";
                var expected = "test";

                CipherActionInfo cipherActionInfo = new CipherActionInfo();
                cipherActionInfo.InFile = inFile;
                cipherActionInfo.OutFile = "test_Decrypt";
                cipherActionInfo.Password = "abc";
                cipherActionInfo.ProgressCallback = callback;

                var actual = cipher.DecryptFile(cipherActionInfo);

                Assert.Equal(expected, actual);

            }
        }


    }
}

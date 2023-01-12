using Autofac;
using FileEncryptDecrypt.DataAccessLayer.IOFiles;
using FileEncryptDecrypt.DomainLayer;
using FileEncryptDecrypt.DomainLayer.Models;
using FileEncryptDecrypt.Services.MultithreadingHelper;
using FileEncryptDecrypt.Services.Validator;
using FileEncryptDecrypt.Utils.Interfaces;

namespace FileEncryptDecrypt.Utils.DependencyInjection
{
    public static class ContainerConfig
    {
        public static Autofac.IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Cipher>().As<ICipher>();
            builder.RegisterType<CipherHelper>().As<ICipherHelper>();
            builder.RegisterType<CryptographyManager>().As<ICryptographyManager>();
            builder.RegisterType<DirectoryProvider>().As<IDirectoryProvider>();
            builder.RegisterType<FileProvider>().As<IFileProvider>();
            builder.RegisterType<FileService>().As<IFileService>();
            builder.RegisterType<PasswordValidator>().As<IPasswordValidator>();
            builder.RegisterType<ThreadQueue>().As<IThreadQueue>();

            return builder.Build();
        }
    }
}

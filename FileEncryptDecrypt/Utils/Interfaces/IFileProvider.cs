﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEncryptDecrypt.Utils.Interfaces
{
    public interface IFileProvider
    {
        FileStream FileOpenRead(string fullFilePath);

        FileStream FileOpenWrite(string fullFilePath);
    }
}

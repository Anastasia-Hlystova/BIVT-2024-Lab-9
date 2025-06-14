﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public interface IFileManager
    {
        string FolderPath { get; }
        string FilePath { get; }
        public void SelectFile(string name);
        public void SelectFolder(string path);
    }
}

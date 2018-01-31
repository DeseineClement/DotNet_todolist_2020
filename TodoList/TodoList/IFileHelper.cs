using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);

    }
}

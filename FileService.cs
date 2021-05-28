using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Module_2_Task_1
{
    public class FileService
    {
        public void Write(string way, string text)
        {
            File.WriteAllText(way, text);
        }
    }
}

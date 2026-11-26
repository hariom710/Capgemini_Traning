using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class MyException:ApplicationException
    {
        public MyException(string message) : base(message)
        {
            string filename= "errorlog.txt";
            string errorMessage = $"{DateTime.Now}: {message}";
            StreamWriter writer = new StreamWriter(filename, true);
            writer.WriteLine(errorMessage);
            writer.Close();

        }
    }
}

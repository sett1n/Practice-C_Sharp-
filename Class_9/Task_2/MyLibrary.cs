using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MyTool
    {
        public static string Input(string messange)
        {
            Console.Write(messange);
            return Console.ReadLine();
        }
    }
}

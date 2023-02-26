using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Mechanism : Detail
    {
        string Name;
        public Mechanism() : base()
        {
            Console.WriteLine("Введите название механизма: ");
            Name = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine(base.Output() + $"Название механизма - {Name}.");
        }
    }
}

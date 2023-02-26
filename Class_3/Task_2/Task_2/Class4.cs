using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Product : Detail
    {
        string Name;
        public Product() : base()
        {
            Console.WriteLine("Введите название изделия: ");
            Name = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine(base.Output() + $"Название изделия - {Name}.");
        }
    }
}

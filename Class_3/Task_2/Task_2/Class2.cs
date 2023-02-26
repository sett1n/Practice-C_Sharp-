using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Yzel : Detail
    {
        string Name;
        int Number;
        public Yzel():base()
        {

            Console.WriteLine("Введите название узла: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите номер узла: ");
            Number = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine(base.Output() + $"Название узла - {Name}, Номер узла - {Number}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Detail
    {
        string Material;
        int Number;
        string Name;
        public Detail()
        {
            Console.WriteLine("Введите название детали: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите номер детали: ");
            Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите материал детали: ");
            Material = Console.ReadLine();
        }
        public virtual string Output()
        {
            return $"Название детали - {Name}, Номер детали - {Number}, Материал детали - {Material}, ";     
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Model
{
    class Building
    {
        public string name;
        public Building()
        {
            this.name = null;
        }
        public virtual void Input()
        {
            Console.Write("Введите название постройки: ");
            name = Console.ReadLine();
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Название: {name}");
        }
    }
}

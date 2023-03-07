using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Model
{
    class Animal
    {
        private string name;
        private double h;
        private double weight;
        private double k;
        public Animal()
        {
            name = null;
            h = 0;
            weight = 0;
            k = 0;
            Input();
        }
        public void GetInfo()
        {
            Console.WriteLine($"Кличка:{name} | Рост:{h}м. | Коэффицент:{k}");
        }
        public virtual void WeightAnimal()
        {
            weight = k * Math.Pow(h, 3);
        }
        public string Name { get { return name; } set { name = value; } }
        public double H { get { return h; } set { h = value; } }
        public double K { get { return k; } set { k = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public void Input()
        {
            Console.Write("Введите кличку животного - ");
            name = Console.ReadLine();
            Console.Write("Введите рост - ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффицент - ");
            k = Convert.ToDouble(Console.ReadLine());
        }
    }
}

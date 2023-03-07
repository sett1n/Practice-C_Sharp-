using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_1.Model
{
    class Cat : Animal
    {
        string breed;
        public Cat() : base()
        {
            Input();
        }
        public void Input()
        {
            Console.Write("Введите породу: ");
            breed = Console.ReadLine();
        }
        public override void WeightAnimal()
        {
            Weight = K * Math.Pow(H, 3) / 1000;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Кличка:{Name} | Рост:{H} м. | Порода:{breed} | Коэффицент {K} | Вес: {Weight} грамм.");
        }
    }
}

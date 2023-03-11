using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_1.Model
{
    internal class Office : Building
    {
        public double N;
        public double HeightFoundation;
        public Office()
        {
            this.N = 0;
            Input();
        }
        public override void Input()
        {
            Console.WriteLine($"Введите количество этажей: ");
            N = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void HeightFoundationFactory()
        {
            HeightFoundation = 0.05 * N;
        }
        public override void GetInfo()
        {
            HeightFoundationFactory();
            Console.WriteLine($"Название:{name} \nКоличество этажей:{N} \nВысота фундамента:{HeightFoundation}.");
        }
    }
}

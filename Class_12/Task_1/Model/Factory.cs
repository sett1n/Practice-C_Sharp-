using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Model
{
    class Factory : Building
    {
        public double G;
        public double HeightFoundation;
        public Factory()
        {
            this.G = 0;
            Input();
        }
        public override void Input()
        {
            Console.WriteLine($"Введите вес: ");
            G = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void HeightFoundationFactory()
        {
            HeightFoundation = 0.000002 * G;
        }
        public override void GetInfo()
        {
            HeightFoundationFactory();
            Console.WriteLine($"Название:{name} \nВес:{G} \nВысота фундамента:{HeightFoundation}.");
        }
    }
}

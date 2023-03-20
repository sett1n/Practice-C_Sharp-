using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Model
{
    internal class CoffeeMachine
    {
        public bool emptyWaterTank;
        public bool emptyCoffeeBeans;
        private static CoffeeMachine uniqueState;

        private CoffeeMachine()
        {
            emptyWaterTank = true;
            emptyCoffeeBeans = true;
        }

        public static CoffeeMachine getState()
        {

            if (uniqueState == null)
            {
                uniqueState = new CoffeeMachine();
            }
            return uniqueState;
        }

        public void addWater()
        {
            if (isEmptyWaterTank())
            {
                emptyWaterTank = false;
                Console.WriteLine("Добавляем воду в кофемашину");
            }
        }

        public void addCoffeeBeans()
        {
            if (isEmptyCoffeeBeans())
            {
                emptyCoffeeBeans = false;
                Console.WriteLine("Добавляем кофейные зерна в кофемашину");
            }
        }

        public void makeCoffee()
        {
            if (!isEmptyWaterTank() && !isEmptyCoffeeBeans())
            {
                Console.WriteLine("Готовим кофе...");
                emptyWaterTank = true;
                emptyCoffeeBeans = true;
            }
        }

        public void coffeeMachineState()
        {
            Console.WriteLine($"Бак с водой пустой - {emptyWaterTank}, бак с кофейными зернами пустой - {emptyCoffeeBeans}");
        }

        public bool isEmptyWaterTank()
        {
            return emptyWaterTank;
        }

        public bool isEmptyCoffeeBeans()
        {
            return emptyCoffeeBeans;
        }
    }
}

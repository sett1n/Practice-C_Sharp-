using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    interface Prototype
    {
        object DeepCopy();
        Prototype Clone();
        public void GetInfo();
        public void AddFish(string fish);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Model
{
    internal class B : A
    {
        private int _d;

        public int C2 { get => _a + _b + _d; }

        public B() : base()
        {

        }

        public B(int a, int b, int d)
        {
            _a = a;
            _b = b;
            _d = d;
        }
    }
}

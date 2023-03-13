using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Model
{
    static class Class1
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            return list._array;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Model
{
    internal class MyDictionary <Tkey, Tval>
    {
        private int counter = 0;
        private Tkey[] keysArr = null;
        private Tval[] valsArr = null;
        public int Counter
        {
            get { return this.counter; }
        }
        public void Add(Tkey key, Tval val)
        {

            if (keysArr == null)
            {
                keysArr = new Tkey[1];
            }
            if (valsArr == null)
            {
                valsArr = new Tval[1];
            }
            Array.Resize(ref keysArr, keysArr.Length + 1);
            Array.Resize(ref valsArr, valsArr.Length + 1);
            keysArr[counter] = key;
            valsArr[counter] = val;
            counter++;
        }
        public Tval GetElem(Tkey key)
        {
            int index = Array.IndexOf(keysArr, key);
            if (index == -1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return valsArr[index];
            }
        }
    }
}

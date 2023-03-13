using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Model
{
    internal class MyList<T>
    {
        private T[] array;
        private int index;
        public int Count
        {
            get { return array == null ? 0 : array.Length; }
        }
        public T[] _array
        {
            get { return array; }
        }
        public void Add(T value)
        {
            if (array == null)
            {
                array = new T[1];
            }
            if (array.Length == index)
            {
                Array.Resize(ref array, array.Length + 1);
            }
            array[index] = value;
            index++;
        }
        public T this[int ind]
        {
            get
            {
                if (array == null)
                    throw new NullReferenceException();
                else
                {
                    if (ind < 0 || ind > array.Length - 1)
                        throw new IndexOutOfRangeException();
                    else
                    {
                        return array[ind];
                    }
                }
            }
        }
    }
}

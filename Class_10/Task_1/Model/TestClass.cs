using System;
using System.Runtime.ConstrainedExecution;
using Task_1.Interface;

namespace Task_1.Model
{
    public class TestClass : Ix, Iy, Iz
    {
        private char _chr;

        public TestClass(char chr)
        {
            _chr = chr;
        }

        public char IxF0(char chr) => char.ToLower(chr);

        public char IxF1() => char.ToLower(_chr);

        public char F0(char chr)
        {
            if (char.IsLetter(chr))
            {
                return '*'; 
            }
            else
            {
                return chr; 
            }
        }

        public char F1()
        {
            if (char.IsLetter(_chr))
            {
                return '*'; 
            }
            else
            {
                return _chr; 
            }
        }
        char Iz.F0(char chr)
        {
            if (char.IsLetter(chr))
            {
                return '5'; 
            }
            else
            {
                return chr; 
            }
        }

        char Iz.F1()
        {
            if (char.IsLetter(_chr))
            {
                return '5'; 
            }
            else
            {
                return _chr; 
            }
        }
    }
}
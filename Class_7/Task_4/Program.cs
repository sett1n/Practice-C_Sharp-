using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            Console.Write("Введите ФИО: ");
            string FIO = Console.ReadLine();
            string[] SplFIO = FIO.Split(' ');

            int sumIndex = 0;
            foreach (string word in SplFIO)
            {
                string s = word.ToLower();
                for (int i = 0; i < s.Length; i++)
                {
                    sumIndex += alphabet.IndexOf(s[i]) + 1;
                }
            }

            int code = 0;
            while (sumIndex > 0)
            {
                code += sumIndex % 10;
                sumIndex = sumIndex / 10;
                if (sumIndex == 0 && code > 9)
                {
                    sumIndex = code;
                    code = 0;
                }
            }
            Console.WriteLine(code);
            Console.ReadLine();

        }
    }
}
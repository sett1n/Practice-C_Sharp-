using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Matrix
    {
        int n;
        double[,] mas;
        int N
        {
            get { return n; }
            set { n = value; }
        }
        double[,] Mas
        {
            get { return mas; }
            set { mas = value; }
        }
        public Matrix(int _n)
        {
            n = _n;
            mas = new double [_n,_n];
            Random rand = new Random();
            for (int i = 0; i < _n; i++)
                for (int j = 0; j < _n; j++)
                    mas[i,j] = rand.Next(21);
        }
        public Matrix(double[,] mas1)
        {
            n = mas1.GetLength(0);
            mas = mas1;
        }
        public Matrix()
        {
            Console.Write("Введите размерность матрицы N на N: ");
            n = int.Parse(Console.ReadLine());
            mas = new double[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    mas[i, j] = rand.Next(21);
        }
        public void Print()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                    Console.Write(mas[i, j] + " ");
            }
            Console.WriteLine();    
        }
        public void Method(int ind)
        {
            double[] mas1 = new double[n];
            for (int j = 0; j < n; j++)
                mas1[j] = mas[ind,j];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = mas[i, j] - mas1[j];
                }
        }

    }
}

using ClassLibrary;
using System;

namespace Task_1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Выберите фигуру 1 - треугольник, 2 - прямоугольник");
            int chosenOperation = Convert.ToInt32(Console.ReadLine());
            switch (chosenOperation)
            {
                case 1:
                    Console.WriteLine("Введите сторону А:");
                    int sideA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите сторону B:");
                    int sideB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите сторону C:");
                    int sideC = Convert.ToInt32(Console.ReadLine());
                    Triangle triangle = new Triangle(sideA, sideB, sideC);

                    bool checkedSides = triangle.allSidesChecker();
                    if (checkedSides != true)
                    {
                        Console.WriteLine("Не все стороны введены");
                    }
                    else
                    {
                        Console.WriteLine("Все стороны введены верно");
                        Console.WriteLine($"Тип треугольника - {triangle.TypeOfTriangle(sideA, sideB, sideC)}");
                        Console.WriteLine($"Периметр треугольника = {triangle.PerimetrOfTriangle(sideA, sideB, sideC)} см");
                        Console.WriteLine($"Площадь треугольника = {triangle.SquareOfTriangle(sideA, sideB, sideC)} см3");
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите длину:");
                    int rectSideA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите ширину:");
                    int rectSideB = Convert.ToInt32(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(rectSideA, rectSideB);
                    Console.WriteLine($"Периметр прямоугольника = {rectangle.PerimetrOfRectangle(rectSideA, rectSideB)} см");
                    Console.WriteLine($"Площадь прямоугольника = {rectangle.SquareOfRectangle(rectSideA, rectSideB)} см3");
                    break;
                default: Console.WriteLine("Операция не выбрана"); break;
            }
        }
    }
}
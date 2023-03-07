using Task_1.Interface;
using Task_1.Model;

TestClass testClass = new TestClass('Т');
Console.WriteLine(testClass.IxF0('В'));
Console.WriteLine(testClass.IxF1());
Console.WriteLine(testClass.F0('В'));
Console.WriteLine(testClass.F1());

TestClass testClass2 = new TestClass('Т');
Console.WriteLine((testClass2 as Iz).F0('В'));
Console.WriteLine((testClass2 as Iz).F1());
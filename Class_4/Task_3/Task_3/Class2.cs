using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Student
    {
        string name;
        string secondName;
        string dataBirth;
        public string Name
        {
            get { return name; } 
            set { name = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        public string DataBirth
        {
            get { return dataBirth; }
            set { dataBirth = value; }
        }
        public Student ()
        {
            Console.Write("Введите Имя студента: ");
            name = Console.ReadLine();
            Console.Write("Введите Фамилию студента: ");
            secondName = Console.ReadLine();
            Console.Write("Введите Дату Рождения студента: ");
            dataBirth = Console.ReadLine();
            Console.WriteLine("---------------------------");
        }
    }
}

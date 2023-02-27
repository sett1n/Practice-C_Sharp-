using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Group
    {
            List<Student> students;
            public Group()
            {
                students = new List<Student>();
            }
            public void AddStudent(Student student)
            {
                students.Add(student);
            }
            public void GetInformation(int index)
            {
            Console.WriteLine();
                if (index > students.Count - 1)
                    throw new Exception("Такого студента нету");
                Console.WriteLine("Имя студента: " + students[index].Name);
                Console.WriteLine("Фамилия студента: " + students[index].SecondName);
                Console.WriteLine("Дата рождения студента: " + students[index].DataBirth);
            Console.WriteLine();
            }
            public void FindByName(string Name)
            {
            Console.WriteLine();
                Console.WriteLine($"Студенты с именем {Name}: ");
                for (int i = 0; i < students.Count; i++)
                    if (students[i].Name == Name)
                        GetInformation(i);
            Console.WriteLine();
            }
        public void FindBySecondName(string SecondName)
        {
            Console.WriteLine();
            Console.WriteLine($"Студенты с фамилией {SecondName}: ");
            for (int i = 0; i < students.Count; i++)
                if (students[i].SecondName == SecondName)
                    GetInformation(i);
            Console.WriteLine();
        }
        public void FindByDateBirth(string DateBirth)
        {
            Console.WriteLine();
            Console.WriteLine($"Студенты с датой рождения {DateBirth}: ");
            for (int i = 0; i < students.Count; i++)
                if (students[i].DataBirth == DateBirth)
                    GetInformation(i);
            Console.WriteLine();
        }
    }
}

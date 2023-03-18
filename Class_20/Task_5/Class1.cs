public class Group
{
    List<Student> students;
    public Group()
    {
        students = new List<Student>();
    }
    /// <summary>
    /// Метод для добавления студента в группу
    /// </summary>
    /// <param name="student">Студент, который будет добавлен</param>
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    // <summary>
    /// Метод для получения информации о студенте по индексу
    /// </summary>
    /// <param name="index">Индекс студента в списке</param>
    /// <exception cref="System.Exception">Выбрасывается, если такого студента нет в списке</exception>
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
    /// <summary>
    /// Метод для поиска студентов по имени
    /// </summary>
    /// <param name="Name">Имя, по которому будет осуществлен поиск</param>
    public void FindByName(string Name)
    {
        Console.WriteLine();
        Console.WriteLine($"Студенты с именем {Name}: ");
        for (int i = 0; i < students.Count; i++)
            if (students[i].Name == Name)
                GetInformation(i);
        Console.WriteLine();
    }
    /// <summary>
    /// Метод для поиска студентов по фамилии
    /// </summary>
    /// <param name="SecondName">Фамилия, по которой будет осуществлен поиск</param>
    public void FindBySecondName(string SecondName)
    {
        Console.WriteLine();
        Console.WriteLine($"Студенты с фамилией {SecondName}: ");
        for (int i = 0; i < students.Count; i++)
            if (students[i].SecondName == SecondName)
                GetInformation(i);
        Console.WriteLine();
    }
    /// <summary>
    /// Метод для поиска студентов по дате рождения
    /// </summary>
    /// <param name="DateBirth">Дата рождения, по которой будет осуществлен поиск</param>
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
using Task_3;

Group group = new Group();
Student student0 = new Student();
Student student1 = new Student();
Student student2 = new Student();
Student student3 = new Student();
group.AddStudent(student0);
group.AddStudent(student1);
group.AddStudent(student2);
group.AddStudent(student3);
group.FindByDateBirth("12");
group.FindByName("Миша");
group.FindBySecondName("Петров");
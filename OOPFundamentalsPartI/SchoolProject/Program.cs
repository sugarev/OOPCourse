namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            Discipline math = new Discipline("Math", 23, 38, "Kofti rabota");
            Discipline physics = new Discipline("Physics", 15, 24);
            List<Discipline> disciplines = new List<Discipline> { math, physics };

            Teacher teacher1 = new Teacher("Gosheva", disciplines);
            Teacher teacher2 = new Teacher("Ivanova", new List<Discipline> 
            {
                new Discipline("Biology", 18, 8),
                new Discipline("Geography", 22, 10)
            });
            List<Teacher> teachersList = new List<Teacher>();
            teachersList.Add(teacher1);
            teachersList.Add(teacher2);

            Student stud1 = new Student("Gosho", 5);
            Student stud2 = new Student("Ivo", 9);
            List<Student> studentsList = new List<Student>();
            studentsList.Add(stud1);
            studentsList.Add(stud2);

            SchoolClass newClass = new SchoolClass("9A", studentsList, teachersList);
            newClass.Teachers.Add(new Teacher("Ivan", new List<Discipline> { new Discipline("Neshto si", 5, 8) }));

            Console.WriteLine(newClass);
        }
    }
}

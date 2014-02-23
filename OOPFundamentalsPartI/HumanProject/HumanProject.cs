namespace HumanProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class HumanProject
    {
        static void Main()
        {
            var allStudents = new List<Student>
            {
                new Student("Kiril", "Popov", 9),
                new Student("Ljubomir", "Todorov", 9),
                new Student("Bojidar", "Malchev", 8),
                new Student("Hristo", "Bogomolov", 7),
                new Student("Pavlin", "Antonov", 10),
                new Student("Kiril", "Dermilov", 8),
                new Student("Zahari", "Malakanov", 10),
                new Student("Yordan", "Pofchev", 11),
                new Student("Vasil", "Gospodinov", 11),
                new Student("Georgi", "Peshev", 12)
            };

            var students = allStudents.OrderBy(st => st.Grade);

            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            var allWorkers = new List<Worker>
            {
                new Worker("Pop", "Kiro", 56, 8),
                new Worker("Todor", "Lyibchev", 68, 8),
                new Worker("Malichko", "Palichko", 82, 10),
                new Worker("Kumcho", "Vylcho", 100, 12),
                new Worker("Baba", "Meca", 180, 6),
                new Worker("Zaio", "Baio", 120, 4),
                new Worker("Ejko", "Bejko", 160, 16),
                new Worker("Evgeni", "Molchev", 110, 2),
                new Worker("Georgi", "Boikov", 450, 20),
                new Worker("Bai", "Dancho", 120, 8)
            };

            var workers = allWorkers.OrderByDescending(wr => wr.MoneyPerHour());
            
            //foreach (var worker in workers)
            //{
            //    Console.WriteLine(worker);
            //}

            var allPeople = new List<IPerson>();
            var studentsAndWorkers = allPeople
                                    .Concat(allStudents)
                                    .Concat(allWorkers)
                                    .ToList();

            var sortedPersons = studentsAndWorkers
                                .OrderBy(pr => pr.FirstName)
                                .ThenBy(pr => pr.LastName);
            
            foreach (var person in sortedPersons)
            {
                Console.WriteLine(person);
            }
        }
    }
}

namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class SchoolClass : SchoolCommonFeatures, IName, IComment
    {
        private List<Student> students;
        private List<Teacher> teachers;

        public SchoolClass(string name, List<Student> student, List<Teacher> teacher) // да провера дали работи с тея IEnumerable
            : this(name, student, teacher, null)
        {
            this.Students = student;
            this.Teachers = teacher;
        }

        public SchoolClass(string name, List<Student> student, List<Teacher> teacher, string comment)
            :base(name, comment)
        { 
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            private set
            {
                this.students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            private set 
            {
                this.teachers = value;
            }
        }

        // Add and Remove students from the class
        public void AddStudent(Student addStudent)
        {
            this.students.Add(addStudent);
        }

        public void RemoveStudent(Student removeStudent)
        {
            this.students.Remove(removeStudent);
        }

        // Add and Remove teachers from the class
        public void AddTeacher(Teacher addTeacher)
        {
            this.teachers.Add(addTeacher);
        }

        public void RemoveTeacher(Teacher removeTeacher)
        {
            this.teachers.Remove(removeTeacher);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("Class: " + this.Name);
            result.AppendLine("Teachers: " + string.Join(", ", this.teachers));
            result.AppendLine("Students: " + string.Join(", ", this.students));
            return result.ToString();
        }
    }
}

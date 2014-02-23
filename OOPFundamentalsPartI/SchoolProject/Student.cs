namespace SchoolProject
{
    using System;
    public class Student : Person, IName, IComment
    {
        public Student(string name, int classNumber) // да провера дали ако не съм сетнал коментар ще ми е нула
            : this(name, classNumber, null)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string name, int classNumber, string comment)
            : base(name, comment)
        {
        }

        public int ClassNumber { get; private set; }

        public override string ToString()
        {
            return this.Name + " " + this.ClassNumber;
        }
    }
}

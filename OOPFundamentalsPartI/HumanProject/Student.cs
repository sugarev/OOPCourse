namespace HumanProject
{
    using System;
    public class Student : Human, IPerson
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get 
            {
                return this.grade;
            }
            private set 
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("Invalid input. Grade value must be between 1 and 12.");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, Grade: {2}", this.FirstName, this.LastName, this.grade);
        }
    }
}

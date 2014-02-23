namespace HumanProject
{
    using System;
    public class Worker : Human, IPerson
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get 
            {
                return this.weekSalary;
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input. Week salary cannot be negative number.");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get 
            {
                return this.workHoursPerDay;
            }
            private set 
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Invalid input for work hours per day. Value cannot be negative number or more than 24.");
                }
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = 0;

            moneyPerHour = this.weekSalary / 5 / this.workHoursPerDay;

            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, Week salary: {2}, Work hours per day: {3}, Money per hour: {4:0.00}", this.FirstName, this.LastName, this.weekSalary, this.workHoursPerDay, this.MoneyPerHour());
        }
    }
}

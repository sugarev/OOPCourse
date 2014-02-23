namespace SchoolProject
{
    using System;
    public class Discipline : SchoolCommonFeatures, IName, IComment
    {
        private int numberLectures;
        private int numberExercises;

        public Discipline(string name, int numberLectures, int numberExercises) // както при другите да провера null
            : this(name, numberLectures, numberExercises, null)
        {
            this.NumberLectures = numberLectures;
            this.NumberExercises = numberExercises;
        }

        public Discipline(string name, int numberLectures, int numberExercises, string comment)
            : base(name, comment)
        {
        }

        public int NumberLectures
        {
            get 
            {
                return this.numberLectures; 
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input.");
                }
                this.numberLectures = value;
            }
        }
        public int NumberExercises
        {
            get 
            {
                return this.numberExercises;
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input.");
                }
                this.numberExercises = value;
            }
        }

        public override string ToString()
        {
            if (this.Comment == null)
            {
                return this.Name + " " + this.numberLectures + " " + this.numberExercises;
            }
            else
            {
                return this.Name + " " + this.numberLectures + " " + this.numberExercises + " " + this.Comment;
            }
        }
    }
}
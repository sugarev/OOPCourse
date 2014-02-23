namespace AnimalProject
{
    using System;
    public class Frog : Animal, ICharacteristics, ISound
    {
        public Frog(string name, double age, Sex sex)
            : base(name, age, sex)
        { 
        }

        public override string ToString()
        {
            return this.Name + " " + this.Age + " " + this.Sex;
        }

        public override void Sound()
        {
            Console.WriteLine("I am {0} the frog, and i say Kuauck", this.Name);
        }
    }
}

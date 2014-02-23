namespace AnimalProject
{
    using System;
    public class Dog : Animal, ICharacteristics, ISound
    {
        public Dog(string name, double age, Sex sex)
            : base(name, age, sex)
        { 
        }

        public override string ToString()
        {
            return this.Name + " " + this.Age + " " + this.Sex;
        }

        public override void Sound()
        {
            Console.WriteLine("The dog {0} says Bayyy.", this.Name);
        }
    }
}

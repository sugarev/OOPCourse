namespace AnimalProject
{
    using System;
    public class Kitten : Cat, ICharacteristics, ISound
    {
        public Kitten(string name, double age)
            : base(name, age, Sex.Female)
        { 
        }

        public override string ToString()
        {
            return this.Name + " " + this.Age + " " + this.Sex;
        }

        public override void Sound()
        {
            Console.WriteLine("The kitten {0} says Myauu, i am female", this.Name);
        }
    }
}

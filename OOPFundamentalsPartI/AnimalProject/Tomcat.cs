namespace AnimalProject
{
    using System;
    public class Tomcat : Cat, ICharacteristics, ISound
    {
        public Tomcat(string name, double age)
            : base(name, age, Sex.Male)
        {
        }
        
        public override void Sound()
        {
            Console.WriteLine("The tomcat {0} says Myauuu, i am male.", this.Name);
        }

        public override string ToString()
        {
            return this.Name + " " + this.Age + " " + this.Sex;
        }
    }
}

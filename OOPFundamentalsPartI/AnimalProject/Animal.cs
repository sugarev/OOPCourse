namespace AnimalProject
{
    using System;
    public abstract class Animal : ICharacteristics, ISound
    {
        public Animal(string name, double age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name { get; private set; }

        public double Age { get; private set; }

        public Sex Sex { get; private set; }

        public abstract void Sound();
    }
}

namespace AnimalProject
{
    using System;
    public abstract class Cat : Animal, ICharacteristics, ISound
    {
        public Cat(string name, double age, Sex sex)
            : base(name, age, sex)
        {
        }
    }
}

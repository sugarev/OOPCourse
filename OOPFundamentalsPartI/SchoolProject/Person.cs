namespace SchoolProject
{
    using System;
    public abstract class Person : SchoolCommonFeatures, IName, IComment
    {
        public Person(string name)
            :base(name) // този констриуктор го създавам, само за да се наследи от класовете под него
        {
        }

        public Person(string name, string comment) // comment е като опция
            : base(name, comment)
        {
        }
    }
}

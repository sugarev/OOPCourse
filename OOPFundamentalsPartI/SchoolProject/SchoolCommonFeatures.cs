namespace SchoolProject
{
    using System;
    public abstract class SchoolCommonFeatures : IName, IComment
    {
        public SchoolCommonFeatures(string name)
        {
            this.Name = name;
        }

        public SchoolCommonFeatures(string name, string comment)
            : this(name)
        {
            this.Comment = comment;
        }

        public string Name { get; private set; }

        public string Comment { get; set; }
    }
}

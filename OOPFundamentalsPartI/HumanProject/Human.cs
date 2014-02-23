﻿namespace HumanProject
{
    using System;
    public abstract class Human : IPerson
    {
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        
        public string FirstName { get; set; }
    
        public string LastName { get; set; }
    }
}

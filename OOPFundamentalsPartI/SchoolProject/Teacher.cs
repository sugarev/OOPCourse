namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    public class Teacher : Person, IName, IComment
    {
        private List<Discipline> discipline;

        public Teacher(string name, List<Discipline> discipline) //да добавя списък с предмети
            : this(name, discipline, null) // да провера дали ако не съм сетнал коментар ще ми е нула
        {
            this.Disciplene = discipline;
        }

        public Teacher(string name, List<Discipline> discipline, string comment) //да добавя списък с предмети
            : base(name, comment)
        {
        }

        public List<Discipline> Disciplene
        {
            get
            {
                return this.discipline;
            }
            private set // без този set не мога да го сложа в конструктора. Да разбера точно защо е така.
            {
                this.discipline = value;
            }
        }

        public void AddDiscipline(Discipline newDiscipline)
        {
            this.discipline.Add(newDiscipline);
        }

        public void RemoveDiscipline(Discipline removeDiscipline)
        {
            this.discipline.Remove(removeDiscipline);
        }

        public override string ToString()
        {
            if (this.Comment == null)
            {
                return  this.Name + " " + string.Join(", ", this.discipline);
            }
            else
            {
                return string.Format("Teacher: {0}, Disciplines: {1} Comment: {2}", this.Name, this.discipline);
            }
            
        }
    }
}

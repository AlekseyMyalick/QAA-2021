using System;
using UniversityDirectory.Enums;

namespace UniversityDirectory
{
    [Serializable]
    public class Subject
    {
        public Subjects Name { get; set; }

        public int Id { get; set; }

        public Subject()
        { }

        public Subject (Subjects name, int id)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nId: {Id}\n";
        }
    }
}

using System;

namespace UniversityDirectory
{
    [Serializable]
    public class Subject
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public Subject()
        { }

        public Subject (string name, int id)
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

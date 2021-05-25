using System;
using System.Collections.Generic;
using UniversityDirectory.Enums;

namespace UniversityDirectory
{
    [Serializable]
    public class Specialty
    {
        public Specialties Name { get; set; }

        public List<int> SubjectsId { get; set; }

        public int Id { get; set; }

        public Specialty() 
        { }

        public Specialty (Specialties name, List<int> subjectsId, int id)
        {
            Name = name;
            SubjectsId = subjectsId;
            Id = id;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nId: {Id} \nSubjects Id: {string.Join(", ", SubjectsId)}\n";
        }
    }
}

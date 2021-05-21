using System;
using System.Collections.Generic;

namespace UniversityDirectory.Persons
{
    [Serializable]
    public class Student : Person
    {
        public List<int> SpecialtiesId { get; set; }

        public int Id { get; set; }

        public Student() 
        { }

        public Student(string firstName, string lastName, int age, int id, List<int> specialtiesId) : base(firstName, lastName, age)
        {
            SpecialtiesId = specialtiesId;
            Id = id;
        }

        public override string ToString()
        {
            return $"First name: {FirstName} \nLast name: {LastName} \nAge: {Age} \nId: {Id} \nSubjects Id: {string.Join(", ", SpecialtiesId)}\n";
        }
    }
}

using System;
using System.Collections.Generic;

namespace UniversityDirectory.Persons
{
    [Serializable]
    public class Professor : Person
    {
        public List<int> SubjectsId { get; set; }

        public int Id { get; set; }

        public Professor() 
        { }

        public Professor (string firstName, string lastName, int age, int id, List<int> subjectsId) : base(firstName, lastName, age)
        {
            Id = id;
            SubjectsId = subjectsId;
        }

        public override string ToString()
        {
            return $"First name: {FirstName} \nLast name: {LastName} \nAge: {Age} \nId: {Id} \nSubjects Id: {string.Join(", ", SubjectsId)}\n";
        }
    }
}

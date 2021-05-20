using System.Collections.Generic;

namespace UniversityDirectory.Persons
{
    class Student : Person
    {
        public List<Specialty> Specialties { get; set; }

        public static int Id = 1;

        public Student(string firstName, string lastName, int age, List<Specialty> specialties) : base(firstName, lastName, age)
        {
            Specialties = specialties;

            Id++;
        }
    }
}

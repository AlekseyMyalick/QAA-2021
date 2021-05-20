using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDirectory.Persons
{
    class Professor : Person
    {
        public List<Subject> Subjects { get; set; }

        public static int Id = 1;

        public Professor (string firstName, string lastName, int age, List<Subject> subjects) : base(firstName, lastName, age)
        {
            Subjects= subjects;

            Id++;
        }
    }
}

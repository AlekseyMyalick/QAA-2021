using System.Collections.Generic;
using UniversityDirectory.Enums;

namespace UniversityDirectory.Departments
{
    class Faculty : Department
    {
        public Faculties Name { get; set; }

        public List<University> Universities { get; set; }

        public static int Id = 1; 

        public Faculty(Faculties name, Person leader, List<Person> staff, List<University> universities) : base(leader, staff)
        {
            Name = name;
            Universities = universities;

            Id++;
        }
    }
}

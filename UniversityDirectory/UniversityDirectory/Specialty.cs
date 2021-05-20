using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityDirectory.Departments;
using UniversityDirectory.Enums;

namespace UniversityDirectory
{
    class Specialty
    {
        public Specialties Name { get; set; }

        public List<Faculty> Faculties { get; set; }

        public static int Id = 1;

        public Specialty (Specialties name, List<Faculty> faculties)
        {
            Name = name;
            Faculties = faculties;

            Id++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDirectory
{
    class Subject
    {
        public string Name { get; set; }

        public List<Specialty> Specialties { get; set; }

        public static int Id = 1;

        public Subject (string name, List<Specialty> specialties)
        {
            Name = name;
            Specialties = specialties;

            Id++;
        }
    }
}

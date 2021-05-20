using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDirectory
{
    class University
    {
        public string Name { get; set; }
        //public List<Department> Departments { get; set; }

        public static int Id = 1;

        public University (string name)//, List<Department> departments)
        {
            Name = name;
            //Departments = departments;

            Id++;
        }
    }
}

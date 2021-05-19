using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDirectory.Departments
{
    class Faculty : Department
    {
        public Faculty(Person leader, List<Person> staff) : base(leader, staff)
        {

        }
    }
}

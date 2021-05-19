using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDirectory.Departments
{
    class ResearchInstitutes : Department 
    {
        public ResearchInstitutes(Person leader, List<Person> staff) : base(leader, staff)
        {

        }
    }
}

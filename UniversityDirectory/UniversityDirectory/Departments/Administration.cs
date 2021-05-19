using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDirectory.Departments
{
    class Administration : Department
    {
        public Administration (Person leader, List<Person> staff) : base(leader, staff)
        {

        }
    }
}

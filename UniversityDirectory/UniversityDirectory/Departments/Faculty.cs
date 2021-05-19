using System.Collections.Generic;

namespace UniversityDirectory.Departments
{
    class Faculty : Department
    {
        public Faculty(Person leader, List<Person> staff) : base(leader, staff)
        {

        }
    }
}

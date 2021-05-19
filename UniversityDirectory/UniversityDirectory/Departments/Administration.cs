using System.Collections.Generic;

namespace UniversityDirectory.Departments
{
    class Administration : Department
    {
        public Administration (Person leader, List<Person> staff) : base(leader, staff)
        {

        }
    }
}

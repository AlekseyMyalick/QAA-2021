using System.Collections.Generic;

namespace UniversityDirectory.Departments
{
    class Household : Department
    {
        public Household(Person leader, List<Person> staff) : base(leader, staff)
        {

        }
    }
}

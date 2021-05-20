using System.Collections.Generic;

namespace UniversityDirectory.Departments
{
    class Security : Department
    {
        public bool IsWorkOnWeekends { get; set; }

        public Security(Person leader, List<Person> staff, bool isWorkOnWeekends) : base(leader, staff)
        {
            IsWorkOnWeekends = isWorkOnWeekends;
        }
    }
}

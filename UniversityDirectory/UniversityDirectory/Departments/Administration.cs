using System.Collections.Generic;

namespace UniversityDirectory.Departments
{
    class Administration : Department
    {
        public Person ViceRector { get; set; }
        public Administration (Person leader, List<Person> staff, Person viceRector) : base(leader, staff)
        {
            ViceRector = viceRector;
        }
    }
}

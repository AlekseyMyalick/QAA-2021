using System.Collections.Generic;

namespace UniversityDirectory.Departments
{
    class ResearchInstitutes : Department 
    {
        public ResearchInstitutes(Person leader, List<Person> staff) : base(leader, staff)
        {

        }
    }
}

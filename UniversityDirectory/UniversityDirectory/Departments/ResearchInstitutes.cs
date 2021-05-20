using System.Collections.Generic;

namespace UniversityDirectory.Departments
{
    class ResearchInstitutes : Department 
    {
        public string ResearchTopic { get; set; }

        public ResearchInstitutes(Person leader, List<Person> staff, string researchTopic) : base(leader, staff)
        {
            ResearchTopic = researchTopic;
        }
    }
}

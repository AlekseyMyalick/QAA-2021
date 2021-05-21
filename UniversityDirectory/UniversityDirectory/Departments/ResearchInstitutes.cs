using System.Collections.Generic;

namespace UniversityDirectory.Departments
{
    class ResearchInstitutes : Department 
    {
        public string ResearchTopic { get; set; }

        public ResearchInstitutes(int leaderId, List<int> staffId, string researchTopic) : base(leaderId, staffId)
        {
            ResearchTopic = researchTopic;
        }
    }
}

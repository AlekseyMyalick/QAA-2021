using System.Collections.Generic;

namespace UniversityDirectory.Departments
{
    class Administration : Department
    {
        public Person ViceRector { get; set; }
        public Administration (int leaderId, List<int> staffId, Person viceRector) : base(leaderId, staffId)
        {
            ViceRector = viceRector;
        }
    }
}

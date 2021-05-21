using System.Collections.Generic;

namespace UniversityDirectory.Departments
{
    class Security : Department
    {
        public bool IsWorkOnWeekends { get; set; }

        public Security(int leaderId, List<int> staffId, bool isWorkOnWeekends) : base(leaderId, staffId)
        {
            IsWorkOnWeekends = isWorkOnWeekends;
        }
    }
}

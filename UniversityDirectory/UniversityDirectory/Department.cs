using System.Collections.Generic;

namespace UniversityDirectory
{
    public abstract class Department
    {
        public int LeaderId { get; set; }

        public List<int> StaffId { get; set; }

        public Department () 
        { }

        public Department (int leaderId, List<int> staffId)
        {
            LeaderId = leaderId;
            StaffId = staffId;
        }
    }
}

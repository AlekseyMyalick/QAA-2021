using System.Collections.Generic;

namespace UniversityDirectory.Departments
{
    class Household : Department
    {
        public int InventoriesCount { get; set; }

        public Household(int leaderId, List<int> staffId, int inventoriesCount) : base(leaderId, staffId)
        {
            InventoriesCount = inventoriesCount;
        }
    }
}

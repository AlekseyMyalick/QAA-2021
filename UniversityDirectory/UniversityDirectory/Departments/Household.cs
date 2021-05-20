using System.Collections.Generic;

namespace UniversityDirectory.Departments
{
    class Household : Department
    {
        public int InventoriesCount { get; set; }

        public Household(Person leader, List<Person> staff, int inventoriesCount) : base(leader, staff)
        {
            InventoriesCount = inventoriesCount;
        }
    }
}

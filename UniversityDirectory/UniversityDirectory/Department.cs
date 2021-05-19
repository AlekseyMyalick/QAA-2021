using System.Collections.Generic;

namespace UniversityDirectory
{
    abstract class Department
    {
        public Person Leader { get; set; }

        public List<Person> Staff { get; set; }

        public Department (Person leader, List<Person> staff)
        {
            Leader = leader;
            Staff = staff;
        }

        public Person this[int index]
        {
            get
            {
                return Staff[index];
            }

            set
            {
                Staff[index] = value;
            }
        }
    }
}

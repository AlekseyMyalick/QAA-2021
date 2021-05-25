using System;
using System.Collections.Generic;

namespace UniversityDirectory
{
    [Serializable]
    public class University
    {
        public string Name { get; set; }

        public List<int> DepartmentsId { get; set; }

        public int Id { get; set; }

        public University() 
        { }

        public University (string name, int id, List<int> departmentsId)
        {
            Name = name;
            DepartmentsId = departmentsId;
            Id = id;
        }

        public override string ToString()
        {
            return $"Departments Id: {string.Join(", ", DepartmentsId)}";
        }
    }
}

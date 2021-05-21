using System;
using System.Collections.Generic;
using UniversityDirectory.Enums;

namespace UniversityDirectory.Departments
{
    [Serializable]
    public class Faculty : Department
    {
        public Faculties Name { get; set; }

        public List<int> SpecialtiesId { get; set; }

        public int Id { get; set; } 

        public Faculty () 
        { }

        public Faculty(Faculties name, int leaderId, List<int> staffId, int id, List<int> specialtiesId) : base(leaderId, staffId)
        {
            Name = name;
            Id = id;
            SpecialtiesId = specialtiesId;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nLeader Id: {LeaderId} \nStaff Id: {string.Join(", ", StaffId)} \nId: {Id} \nSpecialties Id: {string.Join(", ", SpecialtiesId)}\n";
        }
    }
}

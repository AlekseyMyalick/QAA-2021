using System.Collections.Generic;
using System.Linq;
using UniversityDirectory.Persons;
using UniversityDirectory.Departments;
using UniversityDirectory.Builders;
using UniversityDirectory.Enums;

namespace UniversityDirectory
{
    public class Model
    {
        public List<Subject> Subjects { get; set; }

        public List<Professor> Professors { get; set; }

        public List<Student> Students { get; set; }

        public List<Specialty> Specialties { get; set; }

        public List<Faculty> Faculties { get; set; }

        public List<University> Universities { get; set; }

        public Model()
        {
            Subjects = Builder<Subject>.Build("../../XML/Subjects.xml");
            Professors = Builder<Professor>.Build("../../XML/Professors.xml");
            Students = Builder<Student>.Build("../../XML/Students.xml");
            Specialties = Builder<Specialty>.Build("../../XML/Specialties.xml");
            Faculties = Builder<Faculty>.Build("../../XML/Faculties.xml");
            Universities = Builder<University>.Build("../../XML/Universities.xml");
        }

        public List<Professor> UniversityProfessorsTeachingMoreThanOneCourse()
        {
            return Professors.Where(professor => professor.SubjectsId.Count > 1).ToList();
        }

        public List<Student> StudentsInSpecificSpecialty(Specialties specialty)
        {
            var speciltyId = Specialties.SingleOrDefault(specialtyId => specialtyId.Name == specialty);

            if (speciltyId is null)
            {
                return new List<Student>();
            }

            return Students.Where(student => student.SpecialtiesId.Contains(speciltyId.Id)).ToList();   
        }

        //3
        //public IEnumerable<Student> StudentsTakingSpecificSubject(Subjects specificSubject)
        //{
        //    var subjectId = Subjects.SingleOrDefault(subject => subject.Name == specificSubject);

        //    if (subjectId is null)
        //    {
        //        return Enumerable.Empty<Student>();
        //    }
        //    else
        //    {
        //        return Students.Where(student => student.SpecialtiesId);
        //    }
        //}

        public List<Subject> SubjectsThatAreInMoreThanOneSpecialtyOfTheFaculty(Faculties facultyName)
        {
            var faculty = Faculties.SingleOrDefault(f => f.Name == facultyName);

            if (faculty is null)
            {
                return new List<Subject>();
            }

            var specialties = Specialties.Where(s => faculty.SpecialtiesId.Contains(s.Id));

            var subjectsId = specialties.SelectMany(s => s.SubjectsId);

            var subjectsIdMoreThanOne = subjectsId.GroupBy(s => s).Where(s => s.Count() > 1).Select(y => y.Key);

            return Subjects.Where(s => subjectsIdMoreThanOne.Contains(s.Id)).ToList();
        }

        public int ProfessorsNumberAtTheUniversity(string universityName)
        {
            var university = Universities.SingleOrDefault(u => u.Name == universityName);

            if (university is null)
            {
                return 0;
            }

            return Faculties.Where(f => university.DepartmentsId.Contains(f.Id)).SelectMany(s => s.StaffId).Distinct().Count();
        }

        public int SubjectsThatReadAtTheUniversity(string universityName)
        {
            var university = Universities.SingleOrDefault(u => u.Name == universityName);

            if (university is null)
            {
                return 0;
            }

            var specialtiesId = Faculties.Where(f => university.DepartmentsId.Contains(f.Id)).SelectMany(s => s.SpecialtiesId).Distinct();

            return Specialties.Where(s => specialtiesId.Contains(s.Id)).SelectMany(s => s.SubjectsId).Distinct().Count();
        }
    }
}

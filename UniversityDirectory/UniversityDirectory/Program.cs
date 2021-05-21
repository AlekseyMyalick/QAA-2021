using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using UniversityDirectory.Builders;
using UniversityDirectory.Persons;
using UniversityDirectory.Departments;
using UniversityDirectory.Enums;

namespace UniversityDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            //University university = new University("BSU", 1, new List<int>() { 1 });

            //List<University> subjects = new List<University>() { university };
            //Console.WriteLine("Объект создан");

            //XmlSerializer formatter = new XmlSerializer(typeof(List<University>));
            //using (FileStream fs = new FileStream("temp.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, subjects);

            //    Console.WriteLine("Объект сериализован");
            //}

            //using (FileStream fs = new FileStream("temp.xml", FileMode.OpenOrCreate))
            //{
            //    List<University> newPerson = (List<University>)formatter.Deserialize(fs);

            //    Console.WriteLine("Объект десериализован");
            //}

            Builder<University> builder = new Builder<University>();
            var res = builder.Build(@"C:\Users\user\source\repos\QAA-2021\UniversityDirectory\UniversityDirectory\XML\Universities.xml");

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}

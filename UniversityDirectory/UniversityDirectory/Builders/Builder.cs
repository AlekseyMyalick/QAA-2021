using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace UniversityDirectory.Builders
{
    static class Builder<T>
    {
        public static List<T> Build(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                List<T> objects = (List<T>)formatter.Deserialize(fs);

                return objects;
            }
        }
    }
}

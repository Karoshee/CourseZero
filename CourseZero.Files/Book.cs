using System;
using System.IO;
using System.Xml.Serialization;

namespace CourseZero.Files
{
    public class Book
    {
        public string Title { get; set; }

        public Person Author { get; set; }

        public ushort Pages { get; set; }

        public decimal Price { get; set; }

        public DateTime PublicationDate { get; set; }

        public void Serialize(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Book));
            using (Stream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(stream, this);
            }
        }
    }
}

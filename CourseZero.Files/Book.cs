using System;

namespace CourseZero.Files
{
    public class Book
    {
        public string Title { get; set; }

        public Person Author { get; set; }

        public ushort Pages { get; set; }

        public decimal Price { get; set; }

        public DateTime PublicationDate { get; set; }
    }
}

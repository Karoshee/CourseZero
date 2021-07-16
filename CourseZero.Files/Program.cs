using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CourseZero.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonParsing();
            Console.ReadKey();
        }

        public static void DoFileSystem()
        {
            string path = @"C:\Windows\System";
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            string root = allDrives[0].RootDirectory.FullName;
            string[] dirs = Directory.GetDirectories(root);
            string[] files = Directory.GetFiles(dirs[4]);
            FileInfo fileinfo = new FileInfo(files.First());
        }

        public static void MakeStreams()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = Path.Combine(documentsPath, "binfile.bin");

            Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            byte[] bytes = { 10, 21, 43, 103, 100, 123, 200 };
            stream.Write(bytes);
            stream.Close();

            using (stream = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[7];
                stream.Read(bytes, 0, bytes.Length);
                foreach (var oneByte in bytes)
                {
                    Console.Write($"{oneByte} ");
                }
            }
        }

        public static void MakeReadersAndWriters()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = Path.Combine(documentsPath, "textfile.txt");

            //BitConverter.ToChar()
            using (StreamWriter writer = new StreamWriter(filename, true, Encoding.Default))
            {
                writer.WriteLine("Текст, который следует записать");
            }

            using (StreamReader reader = new StreamReader(filename, Encoding.Default))
            {
                string s = reader.ReadToEnd();
                //Console.WriteLine(s);
            }

            using (Stream stream = File.OpenRead(filename))
            {
                if (!stream.CanRead)
                    return;

                using (TextReader reader = new StreamReader(stream, Encoding.Default))
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }

        public static void WithoutReadersAndStreams()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = Path.Combine(documentsPath, "textfile.txt");

            if (File.Exists(filename))
            {
                string text = File.ReadAllText(filename, Encoding.Default);
                Console.WriteLine(text);
                byte[] bytes = File.ReadAllBytes(filename);
            }
            else
            {
                File.AppendText("jfksdajfljdsklfj");
            }
        }

        public static void Serialization()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = Path.Combine(documentsPath, "Book.xml");

            Book book = new Book()
            {
                Title = "The Black Company",
                Author = new()
                {
                    FirstName = "Glen",
                    LastName = "Cook"
                },
                PublicationDate = new DateTime(1984, 5, 6),
                Pages = 384,
                Price = 20.33M
            };

            XmlSerializer xmlSerializer = new XmlSerializer(book.GetType());

            using (Stream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(stream, book);
            }

            book = null;

            using (Stream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                book = xmlSerializer.Deserialize(stream) as Book;
            }

            string json = JsonSerializer.Serialize(book, book.GetType());

            book = null;

            book = JsonSerializer.Deserialize(json, typeof(Book)) as Book;
        }

        public static void XmlParsing()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = Path.Combine(documentsPath, "Book.xml");

            XDocument document = XDocument.Load(filename);

            XElement node = document.Root;

            string[] properties = node.Elements().Select(el => el.ToString()).ToArray();

            node = node.Element("Author");

            string lastname = node.Element("LastName").Value;

            DateTime date = (DateTime)document.Root.Element("PublicationDate");

            document.Root.Add(new XElement("NewProperty", 654215));
        }

        public static void JsonParsing()
        {
            Book book = new Book()
            {
                Title = "The Black Company",
                Author = new()
                {
                    FirstName = "Glen",
                    LastName = "Cook"
                },
                PublicationDate = new DateTime(1984, 5, 6),
                Pages = 384,
                Price = 20.33M
            };

            string jsonString = JsonSerializer.Serialize(book);

            JObject json = JObject.Parse(jsonString);

            var firstname = json["Author"]["FirstName"].Value<string>();

            var date = json.Value<DateTime>("PublicationDate");

            var author = json.GetValue("Author").ToObject<Person>();

            json.Add("NewProperty", 12345);
        }
    }
}

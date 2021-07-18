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

        private static string _GetFullFileName(string filename)
        {
            return Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), 
                filename);
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
            var filename = _GetFullFileName("binfile.bin");

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
            var filename = _GetFullFileName("textfile.txt");

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
            var filename = _GetFullFileName("textfile.txt");

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
            string filename = _GetFullFileName("Book.xml");

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

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Book));
            using (Stream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(stream, book);
            }

            book = null;

            using (Stream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                book = xmlSerializer.Deserialize(stream) as Book;
            }

            book = Deserialize<Book>(filename);
            book.Serialize(filename);

            string json = JsonSerializer.Serialize(book);

            book = null;

            book = JsonSerializer.Deserialize<Book>(json);
        }

        public static T Deserialize<T>(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Book));

            using (Stream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                return (T)xmlSerializer.Deserialize(stream);
            }
        }

        public static void XmlParsing()
        {
            string filename = _GetFullFileName("Book.xml");

            XDocument document = XDocument.Load(filename);

            XElement node = document.Root;

            string[] elementNames = node.Elements().Select(el => el.Name.LocalName).ToArray();

            node = node.Element("Author");

            string lastname = node.Element("LastName").Value;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            
            node.Name = "Person";
            
            using (StringReader reader = new StringReader(node.ToString()))
            {
                var author = xmlSerializer.Deserialize(reader) as Person;
            }

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

            string title = json["Title"].ToString();

            string lastname = json["Author"]["LastName"].ToString();

            var author = json["Author"].ToObject<Person>();

            json.Add("NewProperty", 12345);
        }
    }
}

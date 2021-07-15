using System;
using System.IO;
using System.Net;
using System.Text;

namespace CourseZero.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeReadersAndWriters();
            Console.ReadKey();
        }

        public static void DoFileSystem()
        {
            string path = "C:\\Windows\\System";
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            string root = allDrives[0].RootDirectory.FullName;
            string[] dirs = Directory.GetDirectories(root);
            string[] files = Directory.GetFiles(dirs[0]);
            FileInfo fileinfo = new FileInfo(files[0]);
        }

        public static void MakeStreams()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = Path.Combine(documentsPath, "binfile.txt");

            FileStream stream = File.Open(filename, FileMode.OpenOrCreate, FileAccess.Write);
            byte[] bytes = { 10, 21, 43, 103, 100, 123, 200 };
            stream.Write(bytes);
            stream.Close();

            using (stream = File.Open(filename, FileMode.Open, FileAccess.Read))
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

            using (StreamWriter writer = new StreamWriter(filename, false, Encoding.Default))
            {
                writer.WriteLine("Текст, который следует записать");
            }

            using (StreamReader reader = new StreamReader(filename, Encoding.Default))
            {
                string s = reader.ReadToEnd();
                Console.WriteLine(s);
            }

            using (Stream stream = File.OpenWrite(filename))
            {
                using (TextWriter writer = new StreamWriter(stream, Encoding.Default))
                {
                    writer.WriteLine("Записать весь текст в файл");
                }
            }
        }

        public static void WithoutReadersAndStreams()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = Path.Combine(documentsPath, "textfile.txt");

            if (!File.Exists(filename))
            {
                string text = File.ReadAllText(filename, Encoding.Default);
                Console.WriteLine(text);
            }
            else
            {
                File.WriteAllText(filename, "Записать весь текст в файл", Encoding.Default);
            }
        }

        public static void Serialization()
        {

        }
    }
}

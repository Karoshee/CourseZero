using System;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Net;
using System.Text;

namespace CourseZero.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            WithoutReadersAndStreams();
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


    }
}

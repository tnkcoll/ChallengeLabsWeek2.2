using System.Security.AccessControl;

namespace ChallengeLabsWeek2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateTextFile();
            CopyTextFile();
        }

        public static void CreateTextFile()
        {
            string filePath = "C:\\MSSA-CCAD14\\CreatedFile.txt";

            if (File.Exists(filePath)) 
            {
                File.Delete(filePath);
            }

            using (var creator = File.Create(filePath))
            {
                creator.Close();
            }

            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello!");
                writer.WriteLine("This is my first dynamically created text file");
                writer.Close();
            }

            Console.WriteLine("The file was created successfully");
        }

        public static void  CopyTextFile()
        {
            string filePath = "C:\\MSSA-CCAD14\\CreatedFile.txt";
            string destination = "C:\\MSSA-CCAD14\\CopiedFile.txt";

            File.Copy(filePath, destination, true);

            Console.WriteLine($"The file '{filePath}' was successfully copied to '{destination}'.");
        }
    }
}

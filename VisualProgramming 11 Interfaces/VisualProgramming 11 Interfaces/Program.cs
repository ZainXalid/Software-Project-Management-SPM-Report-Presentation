using System;

namespace VisualProgramming_11_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file1 = new FileInfo();
            FileInfo file2 = new FileInfo();
            file1.ReadFile();
            file1.WriteFile("Content f1");

            file2.ReadFile();

            file2.WriteFile("Content f2");
        }
    }

    interface iFile
    {
        void ReadFile();
        void WriteFile(String Text);
  

        //can't write functions or use access specifiers i.e protected, private other than public
    }

    class FileInfo : iFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile(string Text)
        {
            Console.WriteLine("Writing File");
        }
    }
}

using System;

namespace VisualProgramming8_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Passport p1 = new Passport();
            p1.Number = "123";

            Passport p2 = p1;
            p2.Number = "456";

            PassportStruct s1 = new PassportStruct();
            PassportStruct s2 = s1;

            PassportStruct st1;
            st1.Number = "12";

            Console.WriteLine(st1.Number);

            Console.WriteLine("Passport one : {p1}");
        }
    }
    public class Passport
    {
        public string Number { get; set; }
        public DateTime Expiration { get; set; }
        public String Country { get; set; }

        public static bool IsValid(Passport passport)
        {
            throw new NotImplementedException();
        }
    }

    public struct PassportStruct
    {
        public String Number { get; set; }
        public DateTime Expiration { get; set; }
        public String Country { get; set; }


        public static bool IsValid(Passport passport)
        {
            throw new NotImplementedException();
        }
    }
}

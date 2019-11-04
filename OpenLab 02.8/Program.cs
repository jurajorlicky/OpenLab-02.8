using System;

namespace OpenLab_02._8
{
    class Program
    {
        public static bool IsEmpty(string a)
        {
            return String.IsNullOrEmpty(a);
        }
        static void Main(string[] args)
        {
            string a = "a";
            Console.WriteLine(IsEmpty(a));
        }
    }
}

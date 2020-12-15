using System;

namespace CSharpExercises.Strings
{
    class MakeUppercase
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeUppercaseMethod("modem")); // → "MoDeM"
            Console.WriteLine(MakeUppercaseMethod("BookWorm")); // → "BoOkWoRm"
            Console.WriteLine(MakeUppercaseMethod("Aliquam dolor nisl?")); // → "AlIqUaM DoLoR NiSl?"

            Console.ReadLine();
        }

        static string MakeUppercaseMethod(string str)
        {
            string resultantString = "";

            for (int i = 0; i < str.Length; i+=2)
            {
                str[i].ToString().ToUpper();
            }

            return str;
        }
    }
}

using System;
using CSharpExercises.Arrays;

namespace CSharpExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initial program state");

            Console.WriteLine(GetConcatenationClass.GetConcatenation(new []{1,2,1})); //  →[1,2,1,1,2,1]
            Console.WriteLine(GetConcatenationClass.GetConcatenation(new []{1,3,2,1})); //  → [1,3,2,1,1,3,2,1]

            Console.ReadKey();
            
            Console.ReadLine();
        }
    }
}

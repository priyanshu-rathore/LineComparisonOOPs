using System;

namespace LineComparisonOOPs{
    class Program{
        public static void Main(){
            System.Console.WriteLine("Welcome to line comparison computation program on master branch");
            System.Console.WriteLine("");
            LineComparisonOOPs line = new LineComparisonOOPs();

            int length = line.length();

            System.Console.WriteLine($"length of the line is {length}");
        }
    }
}
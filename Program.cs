using System;

namespace tmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Amit Kumar Sharma";
            System.Console.WriteLine(name);
            string[] words=name.Split(' ');
           /* foreach(string word in words)
            {
                System.Console.WriteLine($"{word}");
            }*/
            string abbr = words[0].Substring(0,1)+"."+ words[1].Substring(0, 1) +"."+ words[2];
            Console.WriteLine(abbr);
        }
    }
}
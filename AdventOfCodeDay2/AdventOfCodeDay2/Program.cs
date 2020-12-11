using System;
using System.Linq;

namespace AdventOfCodeDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            int occurenceOfLetter = 0;
            PasswordManager pm = new PasswordManager();
            foreach (var pwd in pm.GetPasswordsWithoutRequirements())
            {
            }

            Console.WriteLine(occurenceOfLetter);
        }
    }
}

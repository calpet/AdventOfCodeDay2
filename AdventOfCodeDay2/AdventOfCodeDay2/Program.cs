using System;

namespace AdventOfCodeDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordManager pm = new PasswordManager();
            foreach (var pwd in pm.GivenPasswords)
            {
                Console.WriteLine(pwd);
            }
        }
    }
}

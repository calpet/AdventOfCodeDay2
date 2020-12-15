using System;

namespace AdventOfCodeDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            AlgorithmHandler algo = new AlgorithmHandler();
            int amountOfValidPasswords = algo.StartFirstAssignment(new PasswordManager());
            Console.WriteLine("Amount of valid passwords is: " + amountOfValidPasswords);
        }

    }
}

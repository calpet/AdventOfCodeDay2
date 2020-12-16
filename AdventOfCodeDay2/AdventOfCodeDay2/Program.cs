using System;

namespace AdventOfCodeDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First assignment:
            AlgorithmManager algo = new AlgorithmManager();
            int amountOfValidPasswords = algo.StartFirstAssignment(new PasswordManager());
            Console.WriteLine("Amount of valid passwords in the first assignment is: " + amountOfValidPasswords);
            #endregion

            #region Second assignment:
            amountOfValidPasswords = algo.StartSecondAssignment(new PasswordManager());
            Console.WriteLine("Amount of valid passwords in the second assignment is: " + amountOfValidPasswords);
            #endregion


        }

    }
}

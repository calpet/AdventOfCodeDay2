using System;

namespace AdventOfCodeDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First assignment:
            AlgorithmHandler algo = new AlgorithmHandler();
            int amountOfValidPasswords = algo.StartFirstAssignment(new PasswordManagerA());
            Console.WriteLine("Amount of valid passwords is: " + amountOfValidPasswords);
            #endregion


        }

    }
}

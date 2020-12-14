using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AdventOfCodeDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordManager pm = new PasswordManager();
            List<PasswordModel> Passwords = new List<PasswordModel>();
            int amountOfValidPasswords = 0;

            string[] allPasswords = pm.GivenPasswords;
            foreach (var pwd in allPasswords)
            {
                string requirement = pm.SplitRequirementsFromGivenPassword(pwd);
                string plainPassword = pm.GetPasswordWithoutRequirements(pwd);
                int[] occurences = pm.SetOccurenceOfRequirements(requirement);
                char reqLetter = pm.GetRequirementLetter(requirement);
                PasswordModel pModel = new PasswordModel(plainPassword, reqLetter,  occurences[0], occurences[1]);
                pModel.IsValid = IsPasswordValid(pModel);
                if (pModel.IsValid)
                {
                    amountOfValidPasswords++;
                    Passwords.Add(pModel);
                }
                    
            }

            Console.WriteLine("Amount of valid passwords is: " + amountOfValidPasswords);
        }

        public static bool IsPasswordValid(PasswordModel pModel)
        {
            int occurenceOfLetter = 0;
            for (int i = 0; i < pModel.Password.Length; i++)
            {
                
                if (pModel.Password[i] == pModel.RequiredLetter)
                {
                    occurenceOfLetter++;
                }
            }

            return  occurenceOfLetter >= pModel.MinimalOccurence && occurenceOfLetter <= pModel.MaximumOccurence;
        }
    }
}

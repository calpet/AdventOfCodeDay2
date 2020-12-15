using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeDay2
{
    public class AlgorithmHandler
    {

        /// <summary>
        /// This is a method responsible for starting the algorithms of the first assignment.
        /// </summary>
        /// <param name="passwords"></param>
        /// <returns>Amount of valid passwords.</returns>
        public int StartFirstAssignment(PasswordManager passwordManager)
        {
            int amountOfValidPasswords = 0;

            string[] allPasswords = passwordManager.GivenPasswords;
            foreach (var pwd in allPasswords)
            {
                string plainPassword = passwordManager.GetPasswordWithoutRequirements(pwd);
                string requirement = passwordManager.SplitRequirementsFromGivenPassword(pwd);
                int[] occurences = passwordManager.SetOccurenceOfRequirements(requirement);
                char reqLetter = passwordManager.GetRequirementLetter(requirement);
                PasswordModel pModel = new PasswordModel(plainPassword, reqLetter, occurences[0], occurences[1]);

                pModel.IsValid = PasswordModel.IsPasswordValid(pModel);
                if (pModel.IsValid)
                {
                    amountOfValidPasswords++;
                }
            }

            return amountOfValidPasswords;
        }
    }
}

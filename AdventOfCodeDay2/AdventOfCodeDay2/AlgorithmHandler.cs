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
        /// <returns>Amount of valid password.</returns>
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

                pModel.IsValid = IsPasswordValid(pModel);
                if (pModel.IsValid)
                {
                    amountOfValidPasswords++;
                }
            }

            return amountOfValidPasswords;
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

            return occurenceOfLetter >= pModel.MinimalOccurence && occurenceOfLetter <= pModel.MaximumOccurence;
        }
    }
}

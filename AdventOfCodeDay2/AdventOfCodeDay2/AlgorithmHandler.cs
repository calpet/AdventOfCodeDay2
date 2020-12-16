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
        /// <param name="passwordManager"></param>
        /// <returns>Amount of valid passwords.</returns>
        public int StartFirstAssignment(PasswordManager passwordManager)
        {
            int amountOfValidPasswords = 0;

            string[] allPasswords = passwordManager.GivenPasswords();
            foreach (var pwd in allPasswords)
            {
                string plainPassword = passwordManager.GetPasswordWithoutRequirements(pwd);
                string requirement = passwordManager.SplitRequirementsFromGivenPassword(pwd);
                int[] occurences = passwordManager.GetNumbersFromRequirement(requirement);
                char reqLetter = passwordManager.GetRequirementLetter(requirement);
                PasswordModel pModel = new PasswordModel(plainPassword, reqLetter, occurences[0], occurences[1], false);

                pModel.IsValid = PasswordModel.IsPasswordValidA(pModel);
                if (pModel.IsValid)
                {
                    amountOfValidPasswords++;
                }
            }

            return amountOfValidPasswords;
        }

        public int StartSecondAssignment(PasswordManager passwordManager)
        {
            string[] passwords = passwordManager.GivenPasswords();
            int amountOfValidPasswords = 0;
            foreach (var pwd in passwords)
            {
                string plainPassword = passwordManager.GetPasswordWithoutRequirements(pwd);
                string requirement = passwordManager.SplitRequirementsFromGivenPassword(pwd);
                int[] positions = passwordManager.GetNumbersFromRequirement(requirement);
                char reqLetter = passwordManager.GetRequirementLetter(requirement);
                PasswordModel pModel = new PasswordModel(plainPassword, reqLetter, positions[0], positions[1]);

                pModel.IsValid = PasswordModel.IsPasswordValidB(pModel);
                if (pModel.IsValid)
                {
                    amountOfValidPasswords++;
                }
            }

            return amountOfValidPasswords;
        }
    }
}

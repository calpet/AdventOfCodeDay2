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
                //string plainPassword = passwordManager.GetPasswordWithoutRequirements(pwd);
                string[] splittedString = passwordManager.SplitPasswordString(pwd);
                PasswordModel pModel = new PasswordModel(Convert.ToInt32(splittedString[0]), Convert.ToInt32(splittedString[1]), Convert.ToChar(splittedString[2]), splittedString[3],  false);

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
                string[] splittedString = passwordManager.SplitPasswordString(pwd);
                //-2 is done because zero based indexing makes the conditionals go out of bounds. The -2 fixes this, but it looks a bit ugly.
                PasswordModel pModel = new PasswordModel(Convert.ToInt32(splittedString[0]) - 2, Convert.ToInt32(splittedString[1]) - 2, Convert.ToChar(splittedString[2]), splittedString[3]);
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

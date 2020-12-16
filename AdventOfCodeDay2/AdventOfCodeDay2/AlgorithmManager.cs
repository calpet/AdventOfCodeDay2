using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeDay2
{
    public class AlgorithmManager
    {

        /// <summary>
        /// This is a method responsible for starting the algorithms of the first assignment.
        /// </summary>
        /// <param name="passwordManager"></param>
        /// <returns>Amount of valid passwords.</returns>
        public int StartFirstAssignment(PasswordManager passwordManager)
        {
            int amountOfValidPasswords = 0;

            string[] allPasswords = passwordManager.GetPasswords();
            foreach (var pwd in allPasswords)
            {
                string[] pwdString = passwordManager.SplitPasswordString(pwd);
                PasswordModel pModel = new PasswordModel(Convert.ToInt32(pwdString[0]), Convert.ToInt32(pwdString[1]), Convert.ToChar(pwdString[2]), pwdString[3],  false);

                pModel.IsValid = PasswordModel.IsPasswordValidA(pModel);
                if (pModel.IsValid)
                {
                    amountOfValidPasswords++;
                }
            }

            return amountOfValidPasswords;
        }

        /// <summary>
        /// This method is responsible for handling the second assignment.
        /// </summary>
        /// <param name="passwordManager"></param>
        /// <returns>The amount of valid passwords.</returns>

        public int StartSecondAssignment(PasswordManager passwordManager)
        {
            string[] passwords = passwordManager.GetPasswords();
            int amountOfValidPasswords = 0;
            foreach (var pwd in passwords)
            {
                string[] pwdString = passwordManager.SplitPasswordString(pwd);
                //-2 is done because zero based indexing makes the conditionals go out of bounds. The -2 fixes this, but it looks a bit ugly.
                PasswordModel pModel = new PasswordModel(Convert.ToInt32(pwdString[0]), Convert.ToInt32(pwdString[1]), Convert.ToChar(pwdString[2]), pwdString[3]);
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

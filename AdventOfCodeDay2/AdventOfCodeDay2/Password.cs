using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeDay2
{
    public class PasswordModel
    {
        public string Password { get; private set; }
        public char RequiredLetter { get; private set; }
        public int MinimalOccurence { get; private set; }
        public int MaximumOccurence { get; private set; }
        public bool IsValid { get; set; }

        public PasswordModel(string password, char requiredLetter, int minimalOccurence, int maximumOccurence, bool isValid = false)
        {
            Password = password;
            RequiredLetter = requiredLetter;
            MinimalOccurence = minimalOccurence;
            MaximumOccurence = maximumOccurence;
            IsValid = isValid;
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

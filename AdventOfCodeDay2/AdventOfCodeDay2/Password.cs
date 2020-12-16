using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCodeDay2
{
    public class PasswordModel
    {
        public string Password { get; private set; }
        public char RequiredLetter { get; private set; }
        public int MinimalOccurence { get; private set; }
        public int MaximumOccurence { get; private set; }
        public int FirstPosition { get;  }
        public int SecondPosition { get; set; }
        public bool IsValid { get; set; }

        public PasswordModel(int minimalOccurence, int maximumOccurence, char requiredLetter, string password, bool isValid)
        {
            Password = password;
            RequiredLetter = requiredLetter;
            MinimalOccurence = minimalOccurence;
            MaximumOccurence = maximumOccurence;
            IsValid = isValid;
        }

        public PasswordModel(int firstPosition, int secondPosition, char requiredLetter, string password)
        {
            Password = password;
            RequiredLetter = requiredLetter;
            FirstPosition = firstPosition - 1; //-1 because of zero based indexing.
            SecondPosition = secondPosition - 1;
        }

        public static bool IsPasswordValidA(PasswordModel pModel)
        {
            int occurenceOfLetter = pModel.Password.Count(t => t == pModel.RequiredLetter);
            return occurenceOfLetter >= pModel.MinimalOccurence && occurenceOfLetter <= pModel.MaximumOccurence;
        }

        public static bool IsPasswordValidB(PasswordModel pModel)
        {
            bool isValid = false;
            int firstPos = pModel.FirstPosition; 
            int secondPos = pModel.SecondPosition;

            if (pModel.Password[firstPos] == pModel.RequiredLetter && pModel.Password[secondPos] == pModel.RequiredLetter)
            {
                isValid = false;
            } 
            else if (pModel.Password[firstPos] == pModel.RequiredLetter || pModel.Password[secondPos] == pModel.RequiredLetter)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}

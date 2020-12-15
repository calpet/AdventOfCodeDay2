using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCodeDay2
{
    public class PasswordManagerA 
    {
        public string[] GivenPasswords()
        {
            string[] givenPasswords = File.ReadAllLines("Passwords.txt");
            return givenPasswords;
        }
        public string SplitRequirementsFromGivenPassword(string password)
        {
            int index = password.IndexOf(':');
            string requirement = password.Substring(0, index);
            return requirement;
        }

        public string GetPasswordWithoutRequirements(string password)
        {
            int index = password.IndexOf(':');
            string cleanPassword = password.Substring(index + 1);
            return cleanPassword;
        }

        public int[] SetOccurenceOfRequirements(string requirement)
        {
            string[] numbers = Regex.Split(requirement, @"\D+");
            int[] parsedNumbers = new int[numbers.Length];
            int index = 0;
            foreach (var value in numbers)
            {
                if (!String.IsNullOrEmpty(value))
                {
                    parsedNumbers[index] = Convert.ToInt32(value);
                    index++;
                }
            }

            return parsedNumbers;
        }

        public char GetRequirementLetter(string requirement)
        {
            char letter = ' ';

            for (int i = 0; i < requirement.Length; i++)
            {
                int index = requirement.IndexOf(' ');
                string password = requirement.Substring(index + 1);
                letter = Convert.ToChar(password);
            }
            return letter;
        }

        
    }
}

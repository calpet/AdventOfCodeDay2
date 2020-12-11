using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCodeDay2
{
    public class PasswordManager
    {
        private string[] _givenPasswords;
        private string[] _givenRequirements;
        private string[] _cleanPasswords;

        public string[] GivenPasswords
        {
            get
            {
                string[] givenPasswords = File.ReadAllLines("Passwords.txt");
                return givenPasswords;
            }
        }

        public string[] SplitRequirementsFromGivenPasswords()
        {
            string[] passwords = GivenPasswords;
            _givenRequirements = new string[passwords.Length];

            for (int i = 0; i < passwords.Length; i++)
            {
                int index = passwords[i].IndexOf(':');
                string req = passwords[i].Substring(0, index);
                _givenRequirements[i] = req;
            }

            return _givenRequirements;
        }

        public string[] GetPasswordsWithoutRequirements()
        {
            string[] passwords = GivenPasswords;
            _cleanPasswords = new string[passwords.Length];

            for (int i = 0; i < passwords.Length; i++)
            {
                int index = passwords[i].IndexOf(':');
                string password = passwords[i].Substring(index + 1);
                _cleanPasswords[i] = password;

            }

            return _cleanPasswords;
        }

    }
}

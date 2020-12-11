using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCodeDay2
{
    public class PasswordManager
    {
        private string[] givenPasswords;
        public string Password { get; set; }
        public string Requirements { get; set; }

        public string[] GivenPasswords
        {
            get
            {
                givenPasswords = File.ReadAllLines("Passwords.txt");
                return givenPasswords;
            }
        }

    }
}

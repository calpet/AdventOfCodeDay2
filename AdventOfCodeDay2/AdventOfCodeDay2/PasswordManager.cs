using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCodeDay2
{
    public class PasswordManager 
    {
        public string[] GetPasswords()
        {
            string[] givenPasswords = File.ReadAllLines("Passwords.txt");
            return givenPasswords;
        }
        public string[] SplitPasswordString(string password)
        {
            string[] splitString = Regex.Split(password, @"[^0-9a-zA-Z]").Where(s => !String.IsNullOrEmpty(s)).ToArray();
            return splitString;
        }
    }
}

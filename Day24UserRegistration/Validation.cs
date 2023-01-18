using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24UserRegistration
{
    public class Validation
    {
        const string Name = "^[a-zA-Z]{3,}";
        const string Email = "^[a-zA-Z0-9]+[.+-_]{0,1}[a-zA-Z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        const string MobileNumber = "^(91)+[0-9]{10}";
        const string Password = "^[a-z]{8,}([0-9A-Z]{1,})+[.]$";
        public string TestName(string input)
        {
            if (Regex.IsMatch(input, Name))
                return "First/last name matches";
            else
                return "First/last name regex failed";
        }

        public string TestEmail(string input)
        {
            if (Regex.IsMatch(input, Email))
                return "Email  matches";
            else
                return "Email regex failed";
        }

        public string TestMobile(string input)
        {
            if (Regex.IsMatch(input, MobileNumber))
                return "Mobile number  matches";
            else
                return "Mobile number regex failed";
        }

        public string TestPassword(string input)
        {
            if (Regex.IsMatch(input, Password))
                return "Password  matches";
            else
                return "Password regex faild";
        }
    }
}

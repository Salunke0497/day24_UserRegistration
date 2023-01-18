using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24UserRegistration
{
    public class RefactorData
    {
        const string Email = "^[a-zA-Z0-9]+[.+-_]{0,1}[a-zA-Z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        const string Name = "^[a-zA-Z]{3,}";
        const string Password = "^[a-z]{8,}([0-9A-Z]{1,})+[.]$";
        const string MobileNumber = "^(91)+[0-9]{10}";

        string input1;
        public RefactorData(string input1)
        {
            this.input1 = input1;
        }
        /// <summary>
        /// name
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ExceptionRegularRegistration"></exception>
        public string TestName_Refactor()
        {

            if (this.input1.Equals(string.Empty))
                throw new ExceptionRegularRegistration(ExceptionRegularRegistration.RegularRegistrationType.INVALID_NAME, "Name is empty");
            if (Regex.IsMatch(input1, Name))
                return "First/last name matches";
            else
                return "First/last name regex failed";

        }
        /// <summary>
        /// Password
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ExceptionRegularRegistration"></exception>
        public string TestPassword_Refactor()
        {
            if (this.input1.Equals(string.Empty))
                throw new ExceptionRegularRegistration(ExceptionRegularRegistration.RegularRegistrationType.INVALID_PASSWORD, "Password is empty");
            if (Regex.IsMatch(input1, Password))
                return "Password  matches";
            else
                return "Password regex failed";
        }
        /// <summary>
        /// Mobile number
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ExceptionRegularRegistration"></exception>
        public string TestMobile_Refactor()
        {

            if (this.input1.Equals(string.Empty))
                throw new ExceptionRegularRegistration(ExceptionRegularRegistration.RegularRegistrationType.INVALID_Mobile, "Phone number is empty");
            if (Regex.IsMatch(input1, MobileNumber))
                return "Mobile number  matches";
            else
                return "Mobile number regex failed";
        }
        /// <summary>
        /// Email
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ExceptionRegularRegistration"></exception>
        public string TestEmail_Refector()
        {
            if (this.input1.Equals(string.Empty))
                throw new ExceptionRegularRegistration(ExceptionRegularRegistration.RegularRegistrationType.INVALID_Email, "Email is empty");
            if (Regex.IsMatch(input1, Email))
                return "Email  matches";
            else
                return "Email regex failed";
        }
    }
}

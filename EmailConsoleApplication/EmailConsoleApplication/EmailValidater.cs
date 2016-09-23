using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailConsoleApplication
{
    public class EmailValidater
    {
        public const string STR_VALID = "Valid";
        public const string STR_INVALID = "Invalid";

        public string EmailAddress { get; set; }
        public EmailValidater() { }
        public EmailValidater(string emailAddress) { EmailAddress = emailAddress; }

        public bool ValidateEmailAddressUsingRegularExpress(string emailAddress)
        {
            var r = new Regex(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$");

            return !string.IsNullOrEmpty(emailAddress) && r.IsMatch(emailAddress);
        }

        public bool ValidateEmailAddressUsingRegularExpress_Alternative(string emailAddress)
        {
            var r = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$",
                  RegexOptions.IgnoreCase);

            return !string.IsNullOrEmpty(emailAddress) && r.IsMatch(emailAddress);
        }

        public bool IsEmailAddressValid(string emailAddress)
        {
            return ValidateEmailAddressUsingRegularExpress(emailAddress);
        }

        public string String_IsEmailAddressValid(bool emailAddress)
        {
            if (emailAddress)
            {
                return STR_VALID;
            }
            else
            {
                return STR_INVALID;
            }
        }

        public string String_IsEmailAddressValid(string emailAddress)
        {
            if (IsEmailAddressValid(emailAddress))
            {
                return String.Format("Result: {0} for Email {1}",STR_VALID,emailAddress);
            }
            else
            {
                return String.Format("Result: {0} for Email {1}", STR_INVALID, emailAddress);
            }
        }
    }
}

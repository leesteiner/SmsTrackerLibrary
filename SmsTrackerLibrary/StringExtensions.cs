using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmsTrackerLibrary
{
    public static class StringExtensions
    {
        public static bool ValidatePhoneNumber(this string phone, bool IsRequired)
        {
            if (string.IsNullOrEmpty(phone) & !IsRequired)
                return true;

            if (string.IsNullOrEmpty(phone) & IsRequired)
                return false;

            var cleaned = phone.RemoveNonNumerics();

            if (IsRequired)
            {
                if (cleaned.Length == 10)
                    return true;
                else
                    return false;
            }
            else
            {
                if (cleaned.Length == 0)
                    return true;
                else if (cleaned.Length > 0 & cleaned.Length < 10)
                    return false;
                else if (cleaned.Length == 10)
                    return true;
                else
                    return false;
            }

        }

        public static bool ValidateEmailAddress(this string email, bool IsRequired)
        {
            if (string.IsNullOrEmpty(email) & !IsRequired)
                return true;

            if (string.IsNullOrEmpty(email) & IsRequired)
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static string RemoveNonNumerics(this string phone)
        {
            return Regex.Replace(phone, @"[^0-9]+", "");
            //TODO: Fix phone regex? entering text works as a phone number
        }
    }


}

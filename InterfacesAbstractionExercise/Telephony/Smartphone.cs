using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Models.Interfaces;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string phoneNumber)
        {
            if (!ValidatePhoneNumber(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {phoneNumber}";

        }
        public string Browse(string url)
        {
            if (url.Any(char.IsDigit))
            {
               throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }

        private bool ValidatePhoneNumber(string phoneNumber)
             => phoneNumber.All(c => Char.IsDigit(c));

       
    }
}

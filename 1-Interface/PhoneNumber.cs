using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Interface
{
    class PhoneNumber : IFormatter
    {
        private int areaCode { get; set; }
        private int exchangePrefix { get; set; }
        private int phoneNumber { get; set; }
        private string formattedPhoneNumber { get; set; }
        
        public void Format()
        {
            formattedPhoneNumber = ($"({areaCode}) {exchangePrefix}-{phoneNumber}");
        }
        public override string ToString()
        {
            if (formattedPhoneNumber == null)
            {
                this.Format();
            }
            return formattedPhoneNumber;
        }
        public PhoneNumber(string input)
        {
            areaCode = int.Parse(input.Substring(0, 3));
            exchangePrefix = int.Parse(input.Substring(3, 3));
            phoneNumber = int.Parse(input.Substring(6, 4));
            formattedPhoneNumber = null;
        }

    }
}

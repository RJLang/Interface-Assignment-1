using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Interface
{
    class SocialSecurityNumber :IFormatter
    {
        private int groupOne { get; set; }
        private int groupTwo { get; set; }
        private int groupThree { get; set; }
        private string formattedSsn { get; set; }

        public void Format()
        {
            formattedSsn = ($"{groupOne} - {groupTwo} - {groupThree}");
        }

        public override string ToString()
        {
            if (formattedSsn == null)
            {
                this.Format();
            }
            return formattedSsn;
        }

        public SocialSecurityNumber(string input)
        {
            groupOne = int.Parse(input.Substring(0, 3));
            groupTwo = int.Parse(input.Substring(3, 3));
            groupThree = int.Parse(input.Substring(3, 3));
            formattedSsn = null;
        }
    }
}

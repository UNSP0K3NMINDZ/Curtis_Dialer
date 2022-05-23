using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtis_Dialer
{
    abstract class Phone
    {
        private string _companyNumber;
        private string _companyName;
        private int _phoneType;

        public Phone(string companyName, string companyNumber, int phoneType)
        {
            _companyName = companyName;
            _companyNumber = companyNumber;
            _phoneType = phoneType;
        }
        public abstract string Dial();
    }
}

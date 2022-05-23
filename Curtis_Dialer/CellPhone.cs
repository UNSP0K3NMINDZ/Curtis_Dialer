using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtis_Dialer
{
    class CellPhone : Phone
    {
        private string _dialer;
        public CellPhone(string companyName, string companyNumber, int phoneType) : base(companyName, companyNumber, phoneType)
        {
            _dialer = companyName + " is being dialed using 1+ " + companyNumber;
        }
        public override string Dial()
        {
            return _dialer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtis_Dialer
{
    class CellPhone : Phone
    {
        private string _cellDialer;
        public CellPhone(string companyName, string companyNumber, int phoneType) : base(companyName, companyNumber, phoneType)
        {
            _cellDialer = companyName + " is being dialed using 1+" + companyNumber + "...";
        }
        public override string Dial()
        {
            return _cellDialer;
        }
    }
}

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
        private int _yesNo;
        private string _dialer;
        
        public Phone (string companyName, string companyNumber, int cellOrHome)
        {
            _companyName = companyName;
            _companyNumber = companyNumber;
            _yesNo = cellOrHome;
        }
        public string Dial()
        {
            if(_yesNo == 1)
            {
                _dialer = _companyName + " is being dialed using " + _companyNumber + "...";
            }
            else
            {
                _dialer = _companyName + " is being dialed using 1+ " + _companyNumber + "...";
            }
            return _dialer;
        }
    }
}

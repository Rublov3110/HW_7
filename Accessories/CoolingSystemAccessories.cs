using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7.Accessories
{
    public class CoolingSystemAccessories
    {
        private readonly string[] _coolName = new string[3];
        private readonly string[] _coolСountry = new string[3];
        private readonly int[] _coolPrice = new int[3];

        public CoolingSystemAccessories()
        {
            _coolName[0] = "Standard cooling";
            _coolName[1] = "Quiet cooling";
            _coolName[2] = "Water cooling";
            _coolСountry[0] = "Taiwan";
            _coolСountry[1] = "China";
            _coolСountry[2] = "Japan";
            _coolPrice[0] = 20;
            _coolPrice[1] = 50;
            _coolPrice[2] = 100;
        }

        public string[] CoolName
        {
            get { return _coolName; }
        }

        public string[] CoolCountry
        {
            get { return _coolСountry; }
        }

        public int[] CoolPrice
        {
            get { return _coolPrice; }
        }
    }
}

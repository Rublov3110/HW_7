using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7.Accessories
{
    public class RAMAccessories
    {
        private readonly string[] _ramName = new string[3];
        private readonly string[] _ramСountry = new string[3];
        private readonly int[] _ramPrice = new int[3];

        public RAMAccessories()
        {
            _ramName[0] = "NouName 4GB";
            _ramName[1] = "Samsung 8GB";
            _ramName[2] = "Kingston 16GB";
            _ramСountry[0] = "Taiwan";
            _ramСountry[1] = "China";
            _ramСountry[2] = "Japan";
            _ramPrice[0] = 20;
            _ramPrice[1] = 50;
            _ramPrice[2] = 100;
        }

        public string[] RamName
        {
            get { return _ramName; }
        }

        public string[] RamCountry
        {
            get { return _ramСountry; }
        }

        public int[] RamPrice
        {
            get { return _ramPrice; }
        }
    }
}

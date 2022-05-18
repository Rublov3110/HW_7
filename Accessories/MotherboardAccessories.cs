using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7.Accessories
{
    public class MotherboardAccessories
    {
        private readonly string[] _mothBoaName = new string[3];
        private readonly string[] _mothBoaСountry = new string[3];
        private readonly int[] _mothBoaPrice = new int[3];

        public MotherboardAccessories()
        {
            _mothBoaName[0] = "Asus";
            _mothBoaName[1] = "MSI";
            _mothBoaName[2] = "GIGABYET";
            _mothBoaСountry[0] = "Taiwan";
            _mothBoaСountry[1] = "China";
            _mothBoaСountry[2] = "Japan";
            _mothBoaPrice[0] = 50;
            _mothBoaPrice[1] = 100;
            _mothBoaPrice[2] = 160;
        }

        public string[] MothBoaName
        {
            get { return _mothBoaName; }
        }

        public string[] MothBoaCountry
        {
            get { return _mothBoaСountry; }
        }

        public int[] MothBoaPrice
        {
            get { return _mothBoaPrice; }
        }
    }
}

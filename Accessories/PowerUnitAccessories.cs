using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7.Accessories
{
    public class PowerUnitAccessories
    {
        private readonly string[] _powerName = new string[3];
        private readonly string[] _powerСountry = new string[3];
        private readonly int[] _powerPrice = new int[3];

        public PowerUnitAccessories()
        {
            _powerName[0] = "80 Plus 300W";
            _powerName[1] = "80 Plus Gold 450W";
            _powerName[2] = "80 Plus Platinum 650";
            _powerСountry[0] = "Taiwan";
            _powerСountry[1] = "China";
            _powerСountry[2] = "Japan";
            _powerPrice[0] = 30;
            _powerPrice[1] = 50;
            _powerPrice[2] = 80;
        }

        public string[] PowerName
        {
            get { return _powerName; }
        }

        public string[] PowerCountry
        {
            get { return _powerСountry; }
        }

        public int[] PowerPrice
        {
            get { return _powerPrice; }
        }
    }
}

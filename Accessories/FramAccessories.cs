using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7.Accessories
{
    public class FramAccessories
    {
        private readonly string[] _framName = new string[3];
        private readonly string[] _framСountry = new string[3];
        private readonly int[] _framPrice = new int[3];

        public FramAccessories()
        {
            _framName[0] = "Fram Blak";
            _framName[1] = "Fram glass lid";
            _framName[2] = "Fram RGB";
            _framСountry[0] = "Taiwan";
            _framСountry[1] = "China";
            _framСountry[2] = "Japan";
            _framPrice[0] = 10;
            _framPrice[1] = 50;
            _framPrice[2] = 100;
        }

        public string[] FramName
        {
            get { return _framName; }
        }

        public string[] FramCountry
        {
            get { return _framСountry; }
        }

        public int[] FramPrice
        {
            get { return _framPrice; }
        }
    }
}

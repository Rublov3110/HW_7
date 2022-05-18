using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7.Accessories
{
    public class CPUAccessories
    {
        private readonly string[] _cpuName = new string[3];
        private readonly string[] _cpuСountry = new string[3];
        private readonly int[] _cpuPrice = new int[3];

        public CPUAccessories()
        {
            _cpuName[0] = "AMD x2";
            _cpuName[1] = "AMD x4";
            _cpuName[2] = "Intel x8";
            _cpuСountry[0] = "Taiwan";
            _cpuСountry[1] = "China";
            _cpuСountry[2] = "Japan";
            _cpuPrice[0] = 40;
            _cpuPrice[1] = 100;
            _cpuPrice[2] = 150;
        }

        public string[] CpuName
        {
            get { return _cpuName; }
        }

        public string[] CpuCountry
        {
            get { return _cpuСountry; }
        }

        public int[] CpuPrice
        {
            get { return _cpuPrice; }
        }
    }
}
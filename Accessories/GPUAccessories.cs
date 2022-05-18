using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7.Accessories
{
    public class GPUAccessories
    {
        private readonly string[] _gpuName = new string[3];
        private readonly string[] _gpuСountry = new string[3];
        private readonly int[] _gpuPrice = new int[3];

        public GPUAccessories()
        {
            _gpuName[0] = "MSI 2GB";
            _gpuName[1] = "Radiom 4GB";
            _gpuName[2] = "NVideo 8GB";
            _gpuСountry[0] = "Taiwan";
            _gpuСountry[1] = "China";
            _gpuСountry[2] = "Japan";
            _gpuPrice[0] = 150;
            _gpuPrice[1] = 300;
            _gpuPrice[2] = 500;
        }

        public string[] GpuName
        {
            get { return _gpuName; }
        }

        public string[] GpuCountry
        {
            get { return _gpuСountry; }
        }

        public int[] GpuPrice
        {
            get { return _gpuPrice; }
        }
    }
}

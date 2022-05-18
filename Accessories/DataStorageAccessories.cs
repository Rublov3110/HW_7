using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7.Accessories
{
    public class DataStorageAccessories
    {
        private readonly string[] _dataStorageName = new string[3];
        private readonly string[] _dataStorageСountry = new string[3];
        private readonly int[] _dataStoragePrice = new int[3];

        public DataStorageAccessories()
        {
            _dataStorageName[0] = "HDD 1T";
            _dataStorageName[1] = "SSD 500Gb";
            _dataStorageName[2] = "SSD M2 500Gb";
            _dataStorageСountry[0] = "Taiwan";
            _dataStorageСountry[1] = "China";
            _dataStorageСountry[2] = "Japan";
            _dataStoragePrice[0] = 20;
            _dataStoragePrice[1] = 60;
            _dataStoragePrice[2] = 150;
        }

        public string[] DataStorageName
        {
            get { return _dataStorageName; }
        }

        public string[] DataStorageCountry
        {
            get { return _dataStorageСountry; }
        }

        public int[] DataStoragePrice
        {
            get { return _dataStoragePrice; }
        }
    }
}

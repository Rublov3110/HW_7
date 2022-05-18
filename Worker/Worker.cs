using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Accessories;
using HW_7.PC.HousingDerivative;
using HW_7.PC.MotherboardDerivative;

namespace HW_7.Worker
{
    public class Worker : IMake
    {
        private CPUAccessories _cPUAccessories;
        private CPU _cPU;

        private CoolingSystemAccessories _cCoolingSystemAccessories;
        private Cooling _cooling;

        private DataStorageAccessories _dataStorageAccessories;
        private DataStorage _dataStorage;

        private FramAccessories _framAccessories;
        private Fram _fram;

        private GPUAccessories _gpuAccessories;
        private GPU _gpu;

        private MotherboardAccessories _motherboardAccessories;
        private Motherboard _motherboard;

        private PowerUnitAccessories _powerUnitAccessories;
        private PowerUnit _powerUnit;

        private RAMAccessories _rAMAccessories;
        private RAM _rAM;

        public Worker()
        {
            _cPUAccessories = new CPUAccessories();
            _cPU = new CPU();

            _cCoolingSystemAccessories = new CoolingSystemAccessories();
            _cooling = new Cooling();

            _dataStorageAccessories = new DataStorageAccessories();
            _dataStorage = new DataStorage();

            _framAccessories = new FramAccessories();
            _fram = new Fram();

            _gpuAccessories = new GPUAccessories();
            _gpu = new GPU();

            _motherboardAccessories = new MotherboardAccessories();
            _motherboard = new Motherboard();

            _powerUnitAccessories = new PowerUnitAccessories();
            _powerUnit = new PowerUnit();

            _rAMAccessories = new RAMAccessories();
            _rAM = new RAM();
        }

        public void Make(int userInfo)
        {
            _rAM.Name = _rAMAccessories.RamName[userInfo];
            _rAM.Countru = _rAMAccessories.RamCountry[userInfo];
            _rAM.Prise = _rAMAccessories.RamPrice[userInfo];
            _rAM.Get();

            _gpu.Name = _gpuAccessories.GpuName[userInfo];
            _gpu.Countru = _gpuAccessories.GpuCountry[userInfo];
            _gpu.Prise = _gpuAccessories.GpuPrice[userInfo];
            _gpu.Get();

            _cPU.Name = _cPUAccessories.CpuName[userInfo];
            _cPU.Countru = _cPUAccessories.CpuCountry[userInfo];
            _cPU.Prise = _cPUAccessories.CpuPrice[userInfo];
            _cPU.Get();

            _motherboard.Name = _motherboardAccessories.MothBoaName[userInfo];
            _motherboard.Countru = _motherboardAccessories.MothBoaCountry[userInfo];
            _motherboard.Prise = _motherboardAccessories.MothBoaPrice[userInfo];
            _motherboard.Get();

            _cooling.Name = _cCoolingSystemAccessories.CoolName[userInfo];
            _cooling.Countru = _cCoolingSystemAccessories.CoolCountry[userInfo];
            _cooling.Prise = _cCoolingSystemAccessories.CoolPrice[userInfo];
            _cooling.Get();

            _dataStorage.Name = _dataStorageAccessories.DataStorageName[userInfo];
            _dataStorage.Countru = _dataStorageAccessories.DataStorageCountry[userInfo];
            _dataStorage.Prise = _dataStorageAccessories.DataStoragePrice[userInfo];
            _dataStorage.Get();

            _fram.Name = _framAccessories.FramName[userInfo];
            _fram.Countru = _framAccessories.FramCountry[userInfo];
            _fram.Prise = _framAccessories.FramPrice[userInfo];
            _fram.Get();

            _powerUnit.Name = _powerUnitAccessories.PowerName[userInfo];
            _powerUnit.Countru = _powerUnitAccessories.PowerCountry[userInfo];
            _powerUnit.Prise = _powerUnitAccessories.PowerPrice[userInfo];
            _powerUnit.Get();
        }
    }
}

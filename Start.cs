using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Worker;
using HW_7.Accessories;

namespace HW_7
{
    public class Start
    {
        private HW_7.Worker.Worker _worker;

        public Start()
        {
            _worker = new HW_7.Worker.Worker();
        }

        public void Run()
        {
            _worker.Сondition();
        }
    }
}

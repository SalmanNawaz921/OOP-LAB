using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challange_02
{
    public class HosePipe
    {
        private string material = "";
        private string shape = "";
        private float diameter;
        private float flowRate;

        public HosePipe(string material, string shape, float diameter, float flowRate)
        {
            this.material = material;
            this.shape = shape;
            this.diameter = diameter;
            this.flowRate = flowRate;
        }
    }
}

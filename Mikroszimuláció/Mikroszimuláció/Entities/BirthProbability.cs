using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroszimuláció.Entities
{
    public class BirthProbability
    {
        public byte Age { get; set; }
        public int NbrOfChildren { get; set; }
        public double P { get; set; }
    }
}

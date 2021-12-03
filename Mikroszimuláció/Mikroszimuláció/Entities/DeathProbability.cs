using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroszimuláció.Entities
{
    public class DeathProbability
    {
        public Gender Gender { get; set; }
        public int DeathYear { get; set; }
        public double P { get; set; }
    }
}

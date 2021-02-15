using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiLogger.Model
{
    public class State
    {
        public string MachineName { get; set; }
        public string StateName { get; set; }
        public int StateNum { get; set; }
        public DateTime OccursTime { get; set; }

        public State(string StateName, int StateNum, string MachineName, DateTime OccursTime)
        {
            this.StateName = StateName;
            this.StateNum = StateNum;
            this.OccursTime = OccursTime;
            this.MachineName = MachineName;
        }        
    }
}

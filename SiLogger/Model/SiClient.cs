using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiLogger.Model
{
    public class SiClient
    {
        public void Connect() { }
        public void Disconnect() { }

        public event Action<StateUpdates> StateUpdated;

    }
}

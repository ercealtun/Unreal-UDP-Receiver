using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDP_Sender
{
    internal class Parameters
    {
        public List<string> stringToSend { get; set; }
        public List<bool> boolToSend { get; set; }
        public List<int> intToSend { get; set; }
        public List<float> floatToSend { get; set; }

        // Constructor
        public Parameters()
        {
            stringToSend = new List<string>();
            boolToSend = new List<bool>();
            intToSend = new List<int>();
            floatToSend = new List<float>();
        }

    }
}

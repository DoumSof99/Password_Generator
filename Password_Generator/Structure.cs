using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    public class ControlArgs
    {
        public int passLength { get; set; }
        public bool includeSymbols { get; set; }
        public bool includeNumbers { get; set; }
        public bool includeLowercase { get; set; }
        public bool includeUppercase { get; set; }

        public ControlArgs()
        {

        }

    }
}

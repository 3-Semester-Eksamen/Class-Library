using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reading
    {
        public int Id{ get; set; }
        public string MacAddressSensor { get; set; }
        public int OpenedBy { get; set; }
        public DateTime DateTime { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen_ClassLibrary
{
    public class Reading
    {
        public int Id { get; set; }
        public string MacAddressSensor { get; set; }
        public int OpenedBy { get; set; }
        public DateTime TimeStamp { get; set; }

        public void ValidateMacAddressSensor()
        {

        }

        public void ValidateOpenedBy()
        {

        }

        public void ValidateTimeStamp()
        {

        }

        public void Validate()
        {
            ValidateMacAddressSensor();
            ValidateOpenedBy();
            ValidateTimeStamp();
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(MacAddressSensor)}={MacAddressSensor}, {nameof(OpenedBy)}={OpenedBy.ToString()}, {nameof(TimeStamp)}={TimeStamp.ToString()}}}";
        }
    }
}

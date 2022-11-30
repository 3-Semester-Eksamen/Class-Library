using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen_ClassLibrary
{
    public class Key
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public void ValidateName()
        {

        }

        public void ValidateEmail()
        {

        }

        public void ValidatePhone()
        {

        }

        public void Validate()
        {
            ValidateName();
            ValidateEmail();
            ValidatePhone();
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Email)}={Email}, {nameof(Phone)}={Phone}}}";
        }
    }
}

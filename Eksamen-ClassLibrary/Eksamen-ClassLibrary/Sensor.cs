namespace Eksamen_ClassLibrary
{
    public class Sensor
    {
        public string MacAddress { get; set; }
        public string Name { get; set; }

        public void ValidateMacAddress()
        {

        }

        public void ValidateName()
        {

        }

        public void Validate()
        {
            ValidateMacAddress();
            ValidateName();
        }

        public override string ToString()
        {
            return $"{{{nameof(MacAddress)}={MacAddress}, {nameof(Name)}={Name}}}";
        }
    }
}
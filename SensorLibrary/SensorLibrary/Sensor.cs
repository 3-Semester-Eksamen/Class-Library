namespace SensorLibrary
{
    public class Sensor
    {
        public int SensorId { get; set; }
        public string Name { get; set; }

        public void ValidateId()
        {
            if (SensorId == null) throw new ArgumentNullException("Sensor Id må ikke være null");
        }

        public void ValidateName()
        {
            if (Name == null) throw new ArgumentNullException("Name må ikke være null");
            if (Name.Length <= 1) throw new ArgumentOutOfRangeException("Name skal være længere end 1 karakter");
        }

        public void Validate()
        {
            ValidateId();
            ValidateName();
        }

        public override string ToString()
        {
            return $"{{{nameof(SensorId)}={SensorId.ToString()}, {nameof(Name)}={Name}}}";
        }
    }
}
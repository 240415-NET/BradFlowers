namespace BradProjectOne.Models
{
    public class BloodPressureRecord
    {
        public int Systolic { get; set; }
        public int Diastolic { get; set; }
        public int Pulse { get; set; }
        public DateTime Date { get; set; }

        // Parameterless constructor
        public BloodPressureRecord() { }

        // Constructor with parameters that match the property names
        public BloodPressureRecord(int systolic, int diastolic, int pulse, DateTime date)
        {
            Systolic = systolic;
            Diastolic = diastolic;
            Pulse = pulse;
            Date = date;

        }
    }
}






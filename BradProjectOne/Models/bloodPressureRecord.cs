namespace BradProjectOne.Models
{
    public class BloodPressureRecord : UserProfile
    {
        public Guid ReadingId { get; set; }
        public int Systolic { get; set; }
        public int Diastolic { get; set; }
        public int Pulse { get; set; }
        public DateTime Date { get; set; }

        // Parameterless constructor
        public BloodPressureRecord() : base() { }

        // Constructor with parameters that match the property names
        public BloodPressureRecord(Guid userId, string userName, Guid readingId, int systolic, int diastolic, int pulse, DateTime date) 
        : base (userId, userName)
        {
            ReadingId = readingId;
            Systolic = systolic;
            Diastolic = diastolic;
            Pulse = pulse;
            Date = date;
        }
    }
}
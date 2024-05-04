namespace BradProjectOne.Models
{
    public class BloodPressureRecord
    {
        public Guid userId { get; set; }
        public Guid readingId { get; set; }
        public int systolicNumber { get; set; }
        public int diastolicNumber { get; set; }
        public int pulse { get; set; }
        public string dateChecked { get; set; }
    }




}
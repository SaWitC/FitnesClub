namespace FitnesClub.Models
{
    public class Abonement
    {
        public string Id { get; set; } 
        public string Title { get; set; }

        public string Description { get; set; }

        public double Cost { get; set; }
        public DateTime CreateTime { get; set; }

        public bool Status { get; set; }
    }
}

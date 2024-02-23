using System.ComponentModel.DataAnnotations;

namespace JohanResumeeLabb3.Models
{
    public class Jobs
    {
        [Required]
        public int Id { get; set; }
        [Required]

        public string CompanyName { get; set; }
        [Required]

        public int startYear { get; set; }
        [Required]

        public int endYear { get; set; }
        [Required]

        public string roleDescription { get; set; }
        [Required]
        public string ImagePath { get; set; }
    }
}

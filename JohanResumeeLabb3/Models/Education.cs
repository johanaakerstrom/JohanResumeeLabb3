using System.ComponentModel.DataAnnotations;

namespace JohanResumeeLabb3.Models
{
    public class Education
    {
        public int Id { get; set; }
        [Required]

        public string SchoolName { get; set; }
        [Required]

        public int startYear { get; set; }
        [Required]

        public int endYear { get; set; }
        [Required]

        public string Description { get; set; }
    }
}

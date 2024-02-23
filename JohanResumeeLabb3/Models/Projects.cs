using System.ComponentModel.DataAnnotations;

namespace JohanResumeeLabb3.Models
{
    public class Projects
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public string Description { get; set; }
    }
}

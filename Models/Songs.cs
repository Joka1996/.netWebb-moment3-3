using System.ComponentModel.DataAnnotations;

namespace moment3_3.Models
{
    public class Songs
    {
        //properties
        public int Id { get; set; }
        [Required]
        public string? Artist { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public int Length { get; set; }
        [Required]
        public string? Category { get; set; }
        
    }

}

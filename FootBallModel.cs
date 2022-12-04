using System.ComponentModel.DataAnnotations;

namespace FootBallLeage.Models
{
    public class FootBallModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? TeamName1 { get; set; }
        [Required]
        public string? TeamName2 { get; set; }
        [Required]

        public string? Status { get; set; }
       
        public string? WiningTeam { get; set; }
       
        public int Points { get; set; }
       

    }

}

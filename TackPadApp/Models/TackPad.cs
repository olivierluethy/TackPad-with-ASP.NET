using System.ComponentModel.DataAnnotations;

namespace TackPadApp.Models
{
    public class TackPad
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public DateTime DateToComplete { get; set; } = DateTime.Now;
     }
}

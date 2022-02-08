using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace eccomerce.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        [Required]
        //ange(1, 100, ErrorMessage = "Name must be between 1 and 100 only!!")]
        public string Name { get; set; }
        [Required]
        //Range(5, 500, ErrorMessage ="Description must be between 5 and 500 only!!")]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; } 
        [Required]
        public string Genre { get; set; }
        [AllowHtml]
        public string Contents { get; set; }
        [Required]
        public byte[] Image { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
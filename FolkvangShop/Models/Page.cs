using System.ComponentModel.DataAnnotations;

namespace FolkvangShop.Models
{
    public class Page
    {
        public int ID { get; set; }
        [Required]
        public string Titel { get; set; }
        [Required]
        public string Slug { get; set; }
        [Required]
        public string Content { get; set; }
        public int Sorting { get; set; }
    }
}

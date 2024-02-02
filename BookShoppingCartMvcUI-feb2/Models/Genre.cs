using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookShoppingCartMvcUI.Models
{
    [Table("Genre")]
    public class Genre
    {//Genre has a relationship with book class/database
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string? GenreName { get; set; }
        public List<Book> Books { get; set; }

    }
}
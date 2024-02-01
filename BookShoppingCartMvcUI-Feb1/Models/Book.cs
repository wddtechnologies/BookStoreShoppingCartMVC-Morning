using Humanizer.Localisation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookShoppingCartMvcUI.Models
{
    [Table("Book")]
    public class Book
    {//this is the main/base/parent class 
        //has a relationships with many tables 
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string? BookName { get; set; }
        [Required]
        [MaxLength(150)]
        public string? AuthorName { get; set; }
        public double? Price { get; set; }
        public string? Image { get; set; }
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<CartDetail> CartDetails { get; set; }

        [NotMapped]
        public string GenreName {  get; set; }
    }
}

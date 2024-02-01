using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookShoppingCartMvcUI.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    {//remember this already in a relationship with Orders 
        public int Id { get; set; }
        public int StatusId { get; set; }

        [Required, MaxLength(40)]
        public string? StatusName { get; set; }
    }
}

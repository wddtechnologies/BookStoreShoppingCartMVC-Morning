﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvcUI.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {// we will move forward later with this one
        public int Id { get; set; }
        //[Required]
        // public int CartId { get; set; }
        [Required]
        public string UserId { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<CartDetail> CartDetails{ get; set; }



    }
}

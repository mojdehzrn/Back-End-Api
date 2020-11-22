using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularShoppingCartApp.Core.Models.DTOs
{
    public class CartDTO
    {
        public int CartId{ get; set; } = 1;//Primary Key
        public string CartName{ get; set; } = "My Cart";
        public List<CartItemDTO> AllCartItems { get; set; }//Cart is list of CartItems

        public decimal GrandTotal{ get; set; }//sum of SubTotals
    }
}
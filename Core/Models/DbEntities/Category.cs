using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularShoppingCartApp.Core.Models.DbEntities
{
    //This is model for Category
    public class Category
    {
        //Category properties which are columns in the table
        public int CategoryId { get; set; }//Field CategoryId is primary key
        //Name field is required and it's length should not be less than 2
        [Required]
        public string CategoryName { get; set; }
    }
}
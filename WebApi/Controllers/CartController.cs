using Microsoft.AspNetCore.Mvc; // controller class
using System.Collections.Generic;//for retrieving data from database
using System.Linq;//ToList()
using AngularShoppingCartApp.Core.Models;
using AngularShoppingCartApp.Core.Contexts;
using System.Threading.Tasks;//Task
using Microsoft.EntityFrameworkCore;//Include()
using AngularShoppingCartApp.Core.Services;
using AngularShoppingCartApp.Core.Models.DTOs;

namespace MyApp.WebApi.Controllers
{

   [Route("api/[controller]")]//i.e api/Cart --> name of our controller
   [ApiController]//This is Api Controller
    public class CartController: Controller
    {
        private ICartService _service;
        
        //Constructor and dependency injection (constructor injection)
        public CartController(ICartService service)
        {
            _service = service;
        }
        
        //Get list of all the Products inside cart
       [HttpGet]
        public async Task<CartDTO> GetCart()
        {
            return await _service.GetMyCart();
        }     
    }
}
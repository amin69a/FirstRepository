using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class CartDropdownViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var items = new List<BasketItem>() {
                new BasketItem(2,"دیلدو","مشکی")
            };
            return View("_CartDropdown",items);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_Header");
        }
    }
}

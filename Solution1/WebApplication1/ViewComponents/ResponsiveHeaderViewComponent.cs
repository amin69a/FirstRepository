using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class ResponsiveHeaderViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_ResponsiveHeader");
        }
    }
}

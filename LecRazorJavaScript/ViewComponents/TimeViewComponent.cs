using Microsoft.AspNetCore.Mvc;

namespace LecRazorJavaScript.ViewComponents
{
    public class TimeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var time = DateTime.Now;
            return View(time);
        }
    }
}

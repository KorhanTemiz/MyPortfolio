using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace MyPortfolio.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

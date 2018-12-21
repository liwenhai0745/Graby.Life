using Microsoft.AspNetCore.Antiforgery;
using Graby.Life.Controllers;

namespace Graby.Life.Web.Host.Controllers
{
    public class AntiForgeryController : LifeControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

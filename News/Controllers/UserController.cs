

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace News.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Mvc;
    using IdomainHandel;
    using News.Constants;
    public class UserController : Controller
    {
        private readonly InterfaceUser UserService;
        // GET: /<controller>/
        public UserController(InterfaceUser UserService)
        {
            this.UserService = UserService;


        }
        [HttpGet("User", Name = UserControllerRoute.GetIndex)]
        public IActionResult Index()
        {
            var list = this.UserService.GetAll();
            var data = new { succes = true, data = this.UserService.GetAll() };

            return this.Json(data);
        }
    }
}

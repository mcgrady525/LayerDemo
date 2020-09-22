using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LayerDemo.Entity.VO;
using LayerDemo.IService.User;
using Microsoft.AspNetCore.Mvc;
using SSharing.Frameworks.NetCore.Common.Results;
using SSharing.Frameworks.NetCore.Common.Consts;
using SSharing.Frameworks.NetCore.Common.Extends;

namespace LayerDemo.OpenApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetUser(long id)
        {
            var user = _userService.Get(id);
            return Json(user);
        }

        public IActionResult GetUsers(GetUsersRequest request)
        {
            var users = _userService.GetUsers(request);
            return Json(users);
        }
    }
}
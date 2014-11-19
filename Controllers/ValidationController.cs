using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Orchard.Users.Services;

namespace Rimango.BootstrapValidation.Controllers
{
    public class ValidationController : Controller
    {
        private IUserService _userService;
        public ValidationController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: Validation
        [HttpPost]
        public ActionResult ValidateUserName(string fieldValue)
        {
            bool available = _userService.VerifyUserUnicity(fieldValue, "NONE");

            return Json(new { valid = available });
        }

        [HttpPost]
        public ActionResult ValidateUserEmail(string fieldId, string fieldValue)
        {
            bool available = _userService.VerifyUserUnicity(string.Empty, fieldValue);

            return Json(new { valid = available });

        }

        [HttpPost]
        public ActionResult ValidateUserNameEmail(string fieldId, string fieldValue)
        {
            bool available = _userService.VerifyUserUnicity(fieldValue, fieldValue);

            return Json(new { valid = available });
        }
    }
}
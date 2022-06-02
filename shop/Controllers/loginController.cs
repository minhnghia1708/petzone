using shop.code;
using shop.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shop.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            var result = new Account().Login(model.UserName, model.password);
            if (result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                return RedirectToAction("Index", "Home")  ;
            }
            else
            {
                ModelState.AddModelError("", "Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng! "  );
            }
            return View(model);
        }
    }
}
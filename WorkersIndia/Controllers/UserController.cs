using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WorkersIndia.Models;


namespace WorkersIndia.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View();
        }

        public JsonResult Login(string PhoneNumber, string Password)
        {
           
            {
                //return RedirectToAction("NewWorkers");
                //return RedirectToAction("NewWorkers", "User", new { id = 2 });
                //return RedirectToAction("NewWorkers", "User");
                return Json("success", JsonRequestBehavior.AllowGet);
            }

            // return Json("success", JsonRequestBehavior.AllowGet);

        }

        public JsonResult LoginRegister(string PhoneNumber, string Password)
        {
            if (PhoneNumber == null || PhoneNumber == null)
            {

            }

            return Json("success", JsonRequestBehavior.AllowGet);
        }

        //[AllowAnonymous]
       [FilterConfig.NoDirectAccess]

        public ActionResult NewWorkers()
        {
            return View();
        }

        //worker
        [HttpPost]
        [FilterConfig.NoDirectAccess]
        public ActionResult NewWorkers(Newworker model)
        {
            if (ModelState.IsValid)
            {
               // var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
               // var result = await UserManager.CreateAsync(user, model.Password);
               // if (result.Succeeded)
                {
                   // await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                    // Send an email with this link
                    // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

                    return RedirectToAction("Index", "Home");
                }
                //AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }


    }
}
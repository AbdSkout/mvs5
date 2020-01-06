using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc5.Dal;
using mvc5.Models;

namespace mvc5.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }


        public ActionResult sumbit()
        {

            Login loge = new Login();
            
            if (ModelState.IsValid)
            {
                loge.user_name = Request.Form["username"];
                loge.password = Request.Form["password"];

                LoginDal dal = new LoginDal();

                
                List<Login> logins = dal.log.ToList<Login>();

                



                foreach (Login l in logins)
                {
                    if (l.user_name.Equals(loge.user_name) && l.password.Equals(loge.password))
                    {
                        if (l.type == 0)
                            return View("sce");
                        else if (l.type == 1)
                            return View("Lec");
                        else
                            return View("Fac");
                    }


                }
            }



            return View("Login",loge);





        }
    }
 
}
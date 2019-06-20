using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using univercity.Models;

namespace univercity.Controllers
{
    /// <summary>
    /// Controler Master
    /// </summary>
    public class masterController : Controller
    {
        univercityEntities db = new univercityEntities();
        // GET: master
        public ActionResult home()
        {
            return View();
        }
        public ActionResult login()
        {
            TempData["msg"] = "";
            ViewBag.official = new SelectList(db.tbl_official, "code_official", "official_show");

            return View();
        }

        public ActionResult _login(string txt_usernam, string txt_pass, string official)
        {
            //مدیراصلی
            if (official == "1")
            {
                
                tbl_adminstrator tba = db.tbl_adminstrator.Where(a => a.name_user == txt_usernam && a.password == txt_pass).SingleOrDefault();
                if (tba == null)
                {
                    TempData["msg"] = "نام کاربری یا رمز یافت نشد";
                    ViewBag.official = new SelectList(db.tbl_official, "code_official", "official_show");
                    return View("login");
                }
                else
                {
                    Session["user_name"] = txt_usernam;
                    return RedirectToAction("home", "Admin");

                }

            }
           
            //کد سوئیج به پیج مدیر گروه
            //else if (official == "2")
            //{
            //    tbl_adminstrator tba = db.tbl_adminstrator.Where(a => a.name_user == txt_usernam && a.password == txt_pass).SingleOrDefault();
            //    if (tba == null)
            //    {
            //        TempData["msg"] = "نام کاربری یا رمز یافت نشد";
            //        return View("login");
            //    }
            //    else
            //    {
            //        return RedirectToAction("home", "Admin");

            //    }


            //کد سوئیج به پیج اساتید
            //else if (official == "3")
            //{
            //    tbl_adminstrator tba = db.tbl_adminstrator.Where(a => a.name_user == txt_usernam && a.password == txt_pass).SingleOrDefault();
            //    if (tba == null)
            //    {
            //        TempData["msg"] = "نام کاربری یا رمز یافت نشد";
            //        return View("login");
            //    }
            //    else
            //    {
            //        return RedirectToAction("home", "Admin");

            //    }
            //}

            //کد سوئیج به پیج دانشجو
            //else if (official == "3")
            //{
            //    tbl_adminstrator tba = db.tbl_adminstrator.Where(a => a.name_user == txt_usernam && a.password == txt_pass).SingleOrDefault();
            //    if (tba == null)
            //    {
            //        TempData["msg"] = "نام کاربری یا رمز یافت نشد";
            //        return View("login");
            //    }
            //    else
            //    {
            //        return RedirectToAction("home", "Admin");

            //    }
            else
            {
                ViewBag.official = new SelectList(db.tbl_official, "code_official", "official_show");
                return View("login");
            }
               
        }

        public ActionResult show_list()
        {
            return View();
        }

        public ActionResult show_project()
        {
            return View();
        }

        public ActionResult show_offer()
        {
            return View();
        }

        public ActionResult contact_us()
        {
            return View();
        }

    }
}
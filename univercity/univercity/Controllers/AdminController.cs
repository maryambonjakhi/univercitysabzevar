using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using univercity.Models;

namespace univercity.Controllers

{

    /// <summary>
    ///  بد بخت شدیم رفت
    /// </summary>
   
    public class AdminController : Controller
    {
        univercityEntities db = new univercityEntities();
        // GET: Admin
        //***************************************************************
        //شمس آبادی********
        //night test
        public ActionResult home()
        {
            ViewData["msg"] = Session["user_name"];
            return View();
        }

        public ActionResult action_insert_teacher(tbl_teacher_presonal_information tb ,int show_group_lesson)
        {

           
                Teacher_Repository tr = new Teacher_Repository();
                tb.code_group_lesson =show_group_lesson;

                int result = tr.insert_teacher(tb);
                if (result == 0)
                {
                    return HttpNotFound();
                }
                

            
            
            
            return RedirectToAction("show_teacher");



        }
        public void insert_teacher(tbl_teacher_presonal_information tb)
        {
           
                Teacher_Repository tr = new Teacher_Repository();
                int result = tr.insert_teacher(tb);
                if (result == 0)
                {
                    ViewData["msg"] = "عملیات با خطا مواجه شد";
                }
                else

                {
                    ViewData["msg"] = "ثبت با موفقیت انجام شد";
                }
            
             
        }

        public ActionResult formInsert()//فرم تکس باکس های ثبت اطلاعات شخصی اساتید
        {
           ViewBag.show_group_lesson = new SelectList(db.tbl_show_group_lesson, "code_group_lesson", "code_group_lesson_show");
            return View();
        }

        public ActionResult show_teacher()
        {
            List<tbl_teacher_presonal_information> list_teacher = db.tbl_teacher_presonal_information.ToList();
            return View(list_teacher);
        }

        public ActionResult delete_teacher(string id)
        {
            tbl_teacher_presonal_information tb = db.tbl_teacher_presonal_information.Where(c => c.code_national_teacher == id).SingleOrDefault();

            db.tbl_teacher_presonal_information.Remove(tb);
            int result = db.SaveChanges();
            if(result==0)
            {
                ViewBag.message = "failed";
            }
            else
            {
                ViewBag.message = "successful";
            }


            return RedirectToAction("show_teacher");
        }


        public ActionResult Edit(string id="")
        {
            tbl_teacher_presonal_information tb = db.tbl_teacher_presonal_information.Where(c => c.code_national_teacher== id).SingleOrDefault();
            return View();
        }

        public ActionResult edite_teacher(string id)
        {
            string _id = id;
            tbl_teacher_presonal_information tb = db.tbl_teacher_presonal_information.Where(c => c.code_national_teacher == id).SingleOrDefault();
            Teacher_Repository te = new Teacher_Repository();
            te.update_teacher(tb);
            int result = db.SaveChanges();
            
            return RedirectToAction("show_teacher");
        }

        ///     Admin/Edit/5730108940


    }
}
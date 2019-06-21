using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace univercity.Models
{
    public class Teacher_Repository : I_teacher
    {
        univercityEntities db = new univercityEntities();
        public int delete_listteacher(IEnumerable<tbl_teacher_presonal_information> list_teacher)
        {
            db.tbl_teacher_presonal_information.RemoveRange(list_teacher);
            return db.SaveChanges();
        }

        public int delete_teacher(tbl_teacher_presonal_information tb)
        {
            db.tbl_teacher_presonal_information.Remove(tb);
            return db.SaveChanges();
        }

        public tbl_teacher_presonal_information find_teacher(string code_national_teacher)
        {
            tbl_teacher_presonal_information teacher = db.tbl_teacher_presonal_information.Where(c => c.code_national_teacher == code_national_teacher).SingleOrDefault();
            return teacher;
        }

        public List<tbl_teacher_presonal_information> find_teachers(string code_national_teacher)
        {
           List< tbl_teacher_presonal_information> teacher = db.tbl_teacher_presonal_information.Where(c => c.code_national_teacher == code_national_teacher).ToList();
            return teacher;
        }

        public int insert_listteacher(IEnumerable<tbl_teacher_presonal_information> list_teacher)
        {
            db.tbl_teacher_presonal_information.AddRange(list_teacher);
            return db.SaveChanges();
        }

        public int insert_teacher(tbl_teacher_presonal_information tb)
        {
            db.tbl_teacher_presonal_information.Add(tb);
            return db.SaveChanges();
        }

        public int update_teacher(tbl_teacher_presonal_information tb)
        {
            db.Entry(tb).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
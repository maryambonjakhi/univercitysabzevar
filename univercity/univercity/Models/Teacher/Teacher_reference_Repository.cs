using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace univercity.Models.Teacher
{
    public class Teacher_reference_Repository : I_teacher_reference
    {
        univercityEntities db = new univercityEntities();

        public int delete_teacher_reference(tbl_teacher_reference tb)
        {
            db.tbl_teacher_reference.Remove(tb);
            return db.SaveChanges();
        }

        public List<tbl_teacher_reference> find_teachers_reference(string code_national_teacher)
        {
            throw new NotImplementedException();
        }

        public tbl_teacher_reference find_teacher_reference(string code_national_teacher)
        {
            throw new NotImplementedException();
        }

        public int insert_teacher_reference(tbl_teacher_reference tb)
        {
            throw new NotImplementedException();
        }

        public int update_teacher_reference(tbl_teacher_reference tb)
        {
            throw new NotImplementedException();
        }
    }
}
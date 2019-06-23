using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univercity.Models;

namespace univercity
{
   public interface I_teacher_reference
    {
        int insert_teacher_reference(tbl_teacher_reference tb);
        int delete_teacher_reference(tbl_teacher_reference tb);
        int update_teacher_reference(tbl_teacher_reference tb);
        tbl_teacher_reference find_teacher_reference(string code_national_teacher);
        List<tbl_teacher_reference> find_teachers(string code_national_teacher);


    }
}

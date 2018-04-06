using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using wevap.Context;
using wevap.Models;

namespace wevap.Datos
{
    public class TeacherData
    {
        
        public void SaveTeacherSubject(Teacher teacher)
        {
            try
            {
                using (SDBcontext db = new SDBcontext())
                {
                    db.Database.ExecuteSqlCommand("DELETE FROM TeacherSubjects WHERE Teacher_DNI=@id",
                                                    new SqlParameter("id", teacher.DNI));
                    db.SaveChanges();
   
                    foreach (var subject in teacher.Subjects)
                    {
                       
                        db.Database.ExecuteSqlCommand("INSERT INTO TeacherSubjects VALUES(@dni,@di)",
                                                    new SqlParameter("dni", teacher.DNI),
                                                    new SqlParameter("di", subject.Id_Subject));
                        db.SaveChanges();

                    }

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
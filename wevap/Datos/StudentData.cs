using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wevap.Context;
using wevap.Models;

namespace wevap.Datos
{
    public class StudentData
    {
        public List<Student> GetStudents()
        {
            try
            {
                using (SDBcontext db = new SDBcontext())
                {
                    return db.tblStudent.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
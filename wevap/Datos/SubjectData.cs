using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wevap.Context;
using wevap.Models;

namespace wevap.Datos
{
    public class SubjectData
    {
        private Subject subject = new Subject();

        public List<Subject> GetSubjects()
        {
            var subjectList = new List<Subject>();
            try
            {
                using(SDBcontext db= new SDBcontext())
                {
                    subjectList = db.tblSubject.ToList();
                    var orderSubjects = subjectList.OrderBy(x => x.Description);
                    subjectList = orderSubjects.ToList();
                }
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            return subjectList;
        }
    }
}
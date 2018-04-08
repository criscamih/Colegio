using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wevap.Context;
using wevap.Models.QueryModels;

namespace wevap.Datos
{
    public class SubjectLevelData
    {
        private SubjectLevel subjectLevel = new SubjectLevel();

        public List<SubjectLevel> GetQuerySubjectLevel()
        {
            List<SubjectLevel> queryList = new List<SubjectLevel>();
            try
            { 
                using (SDBcontext db= new SDBcontext())
                {
                    var query = from l in db.tblLevel
                            join s in db.tblSubject
                            on l.Id_Level equals s.Level.Id_Level
                            select new
                            {
                                Stage = l.Stage,
                                Description=s.Description,
                                Credits=s.Credits
                            };

                    foreach (var q in query)
                    {
                        queryList.Add(new SubjectLevel
                        {
                            Stage = q.Stage,
                            Description = q.Description,
                            Credits = q.Credits
                        });
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return queryList;
        }
    }
}
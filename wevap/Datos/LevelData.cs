using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wevap.Context;
using wevap.Models;

namespace wevap.Datos
{
    public class LevelData
    {
        private Level level = new Level();
        
        public List<Level> GetLevels()
        {
            List<Level> levelList = new List<Level>();
            try
            {
                using (SDBcontext db=new SDBcontext())
                {
                    levelList = db.tblLevel.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            return levelList;
        }
    }
}
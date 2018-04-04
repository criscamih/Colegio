using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using wevap.Models;

namespace wevap.Context
{
    public class SDBcontext:DbContext
    {
        public DbSet<Student> tblStudent { get; set; }
        public DbSet<Subject> tblSubject { get; set; }
        public DbSet<StudentSubject> tblScores{ get; set; }
        public DbSet<Teacher> tblTeacher { get; set; }
        public DbSet<Level> tblLevel { get; set; }
    }
}
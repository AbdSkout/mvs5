using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using mvc5.Models;
namespace mvc5.Dal
{

    public class LoginDal :DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Login>().ToTable("user");//mabye here mistake dbo.user
        }
        public DbSet<Login> log { get; set; }



    }
}
using MIS4800_940.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MIS4800_940.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection") 
        { 
        
        }
        public DbSet<Employees>  Employees { get; set; }
        public DbSet<Patient>  Patient { get; set; }
        public DbSet<Bill>  Bill { get; set; }
        public DbSet<Appointment>  Appointment { get; set; }
        public DbSet<Payment>  Payment { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlmirVjezbaContext.Models;

namespace AlmirVjezbaContext.Context
{
    public class MyContext : DbContext
    {
        public MyContext() :
        base("Name=MyConnectionsting")
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<MeterManufacturer> MeterManufacturer { get; set; }
        public DbSet<MeterType> MeterType { get; set; }
        public DbSet<Meter> Meter { get; set; }
    }
}

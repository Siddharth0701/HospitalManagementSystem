using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class ApplicationDbContext:DbContext
    {
        string connectionString = "Server=SIDDHARTH-SINGH;Database=hospitalmangem; integrated security=SSPI;trustservercertificate=True;MultipleActiveResultSets=true";

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            

        }
        public DbSet<NewUserRegister> NewUserRegister{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}

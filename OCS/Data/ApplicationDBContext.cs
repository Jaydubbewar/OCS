//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OCS.Models;
using OCS.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OCS.Data
{ 
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
        {

        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }        
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<DoctorIntimation> DoctorIntimations { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace TaskDB.Models
    {
    class RecruitTaskContext:DbContext
        {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<WorkTask> WorkTasks { get; set; }
        public DbSet<WorkTaskType> WorkTaskTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.EmployeeId);

            modelBuilder.Entity<WorkTaskType>()
                .HasKey(w => w.WorkTasktTypeId);

            modelBuilder.Entity<WorkTask>()
                .HasKey(e => e.WorkTaskId);
            modelBuilder.Entity<WorkTask>()
                .HasRequired<WorkTaskType>(t => t.WorkTaskType)
                .WithMany(w => w.WorkTasks)
                .HasForeignKey(k => k.WorkTaskTypeId);
            modelBuilder.Entity<WorkTask>()
                .HasMany<Employee>(w => w.AssignedEmployees)
                .WithMany(e => e.WorkTasks);
            }
        }
    }

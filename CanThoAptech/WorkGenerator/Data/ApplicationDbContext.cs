﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WorkGenerator.Models;

namespace WorkGenerator.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Skill> Skill { get; set; } 
        
        public DbSet<Category> Category { get; set; }

        public DbSet<Job> Job { get; set; }
        
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Event> Event { get; set; }

        public DbSet<UserEvent> UserEvent { get; set; }

        public DbSet<Training> Training { get; set; }

        public DbSet<AppliedDetails> AppliedDetails { get; set; }

        public DbSet<JobApply> JobApply { get; set; }
    }
}

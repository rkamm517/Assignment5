﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}

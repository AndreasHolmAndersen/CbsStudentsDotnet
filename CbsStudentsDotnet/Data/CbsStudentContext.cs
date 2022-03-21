#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cbsStudents.Models.Entities;

    public class CbsStudentContext : DbContext
    {
        public CbsStudentContext (DbContextOptions<CbsStudentContext> options)
            : base(options)
        {
        }

        public DbSet<cbsStudents.Models.Entities.Post> Post { get; set; }
    }

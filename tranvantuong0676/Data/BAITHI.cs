using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TRANVANTUONG0676.Models;

    public class BAITHI : DbContext
    {
        public BAITHI (DbContextOptions<BAITHI> options)
            : base(options)
        {
        }

        public DbSet<TRANVANTUONG0676.Models.TVTstudent> TVTstudent { get; set; } = default!;
    }

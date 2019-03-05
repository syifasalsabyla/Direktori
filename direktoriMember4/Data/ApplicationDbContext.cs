using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using direktoriMember4.Models;

namespace direktoriMember4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<direktoriMember4.Models.Produk> Produk { get; set; }
        public DbSet<direktoriMember4.Models.Member> Member { get; set; }
        public DbSet<direktoriMember4.Models.SOHeader> SOHeader { get; set; }
        public DbSet<direktoriMember4.Models.SOLine> SOLine { get; set; }
    }
}

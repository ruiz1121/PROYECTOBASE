using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.JSInterop.Infrastructure;
using proyecto_sena.Models;

namespace proyecto_sena.Data
{
    public class DBcontext : DbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options) : base(options) { }
        public DbSet<usuarioModel> usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usuarioModel>().HasKey(U => U.usuario_Id);
            modelBuilder.Entity<usuarioModel>().Property(U => U.usuario_Id).ValueGeneratedOnAdd();
        }
    }
}
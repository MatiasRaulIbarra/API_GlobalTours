using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entidades;
using Microsoft.EntityFrameworkCore;

namespace API.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Lugar> Lugar{get;set;}
    }
}
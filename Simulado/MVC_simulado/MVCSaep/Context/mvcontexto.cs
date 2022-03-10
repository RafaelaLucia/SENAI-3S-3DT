using Microsoft.EntityFrameworkCore;
using MVCSaep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSaep.Context
{
        public class Mvcontexto : DbContext
        {
            public Mvcontexto(DbContextOptions<Mvcontexto> options)
                       : base(options)
            {
            }

            public DbSet<Perfis> Perfis { get; set; }
            public DbSet<Usuarios> Usuarios { get; set; }
            public DbSet<Equipamentos> Equipamentos { get; set; }
            public DbSet<Comentarios> Comentarios { get; set; }
        }
    }

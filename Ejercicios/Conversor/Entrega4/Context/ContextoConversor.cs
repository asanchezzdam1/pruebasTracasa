﻿using Entidades.Entities;
using Microsoft.EntityFrameworkCore;
namespace Context
{
    public class ContextoConversor : DbContext
    {

        public ContextoConversor(DbContextOptions<ContextoConversor> opciones) : base(opciones)
        {
        }

        public DbSet<Moneda> monedas { get; set; }
        public DbSet<Historial> historial { get; set; }
        public DbSet<Pais> paises { get; set; }
        public DbSet<Usuario> usuarios { get; set; }

    }
}
using Microsoft.EntityFrameworkCore;
using Proyecto_Unidad_1_23BV.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad_1_23BV.Context
{
    internal class AplicationdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL("server = localhost; database = proyectou1; user = root; password = ");
        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}

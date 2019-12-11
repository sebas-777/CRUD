using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BioHealthy.Models
{
    public class EmpleadosContext:DbContext
    {
        public EmpleadosContext(DbContextOptions<EmpleadosContext>options):base(options)
        {
        }

        public DbSet<Empleado>Empleados { get; set; }



    }
}

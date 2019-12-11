using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BioHealthy.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }
        [Column("nvarchar(250)")]
        public string Apellidos { get; set; }
        [Column("varchar(30)")]
        public string Nombre { get; set; }
        [Column("varchar(20)")]
        public int Documento { get; set; }
        [Column("nvarchar(50)")]
        public string Cargo { get; set; }
        [Column("varchar(25)")]
        public string Ciudad { get; set; }
        [Column("date(15)")]
        public DateTime Fecha { get; set; }
        [Column("date(10)")]
        public DateTime Hora { get; set; }

    }
}

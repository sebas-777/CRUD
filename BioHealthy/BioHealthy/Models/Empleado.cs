using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Required]
        [DisplayName("Apellidos")]
        public string Apellidos { get; set; }
        [Column("varchar(30)")]
        [Required(ErrorMessage = "Campo Requerido.")]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [Column("varchar(20)")]
        [Required(ErrorMessage = "Campo Requerido.")]
        [DisplayName("Documento")]
        
        public int Documento { get; set; }
        [Column("nvarchar(50)")]
        [Required(ErrorMessage = "Campo Requerido.")]
        [DisplayName("Cargo")]
        public string Cargo { get; set; }
        [Column("varchar(25)")]
        [Required(ErrorMessage = "Campo Requerido.")]
        [DisplayName("Ciudad")]
        public string Ciudad { get; set; }
        [Column("date(15)")]
        [DisplayName("Fecha")]
        public DateTime Fecha { get; set; }
        [Column("date(10)")]
        [DisplayName("Hora")]
        public DateTime Hora { get; set; }

    }
}

using System;

namespace ProyectoSSASA.Models
{
    public class Empleado
    {
        // Campos obligatorios
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DPI { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int CodigoDepartamento { get; set; }
        public int Estatus { get; set; }  // Activo/Inactivo (1/0)
        public string Cargo { get; set; }

        // Campos opcionales
        public string Direccion { get; set; }
        public string NIT { get; set; }
        public decimal? Sueldo { get; set; }
        public decimal? Bonificacion { get; set; }

        // Auditoría
        public DateTime FechaCrea { get; set; }
        public string UsuarioCrea { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string UsuarioModifica { get; set; }
    }
}

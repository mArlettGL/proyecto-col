using ProyectoSSASA.Models;
using System;
using System.Data;
using System.Data.SqlClient;

public class EmpleadoDataAccess
{
    private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    public void InsertarEmpleado(Empleado empleado)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand("sp_InsertarEmpleado", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros correspondientes a la tabla Empleados
                cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("@DPI", empleado.DPI);
                cmd.Parameters.AddWithValue("@sexo", empleado.Sexo);
                cmd.Parameters.AddWithValue("@fechaNacimiento", empleado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@direccion", empleado.Direccion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NIT", empleado.NIT ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("@fechaIngreso", empleado.FechaIngreso);
                cmd.Parameters.AddWithValue("@sueldo", empleado.Sueldo.HasValue ? (object)empleado.Sueldo.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@bonificacion", empleado.Bonificacion.HasValue ? (object)empleado.Bonificacion.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@codigoDepartamento", empleado.CodigoDepartamento);
                cmd.Parameters.AddWithValue("@estatus", empleado.Estatus);
                cmd.Parameters.AddWithValue("@cargo", empleado.Cargo);
                cmd.Parameters.AddWithValue("@usuarioCrea", empleado.UsuarioCrea ?? (object)DBNull.Value);

                // Ejecutar el comando
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }

    // Implementa otros métodos como ActualizarEmpleado, ObtenerReporteEmpleados

}

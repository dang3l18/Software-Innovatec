using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{
    class Usuario
    {
        public static int CrearCuentas(string pUsuario, string PContraseña, bool Consultar, bool Registrar, bool Su)

        {
            int resultado = 0;
            try
            {
                CONEXION.opencon();
                SqlCommand comando = new SqlCommand(string.Format("Insert into Usuarios(Nombre, Contraseña, Consultar, Registrar, Su ) values ('{0}', '{1}', '{2}', '{3}', '{4}',)",
                    pUsuario, PContraseña, Consultar, Registrar, Su), CONEXION.obtenerconexión());

                resultado = comando.ExecuteNonQuery();
                CONEXION.cerrarcon();
            }
            catch (SqlException ex)


            {
                MessageBox.Show("Error al Guardar" + ex.Message);
            }
            return resultado;
        }
    }
}
    


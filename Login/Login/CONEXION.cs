using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Login
{
   public  class CONEXION
    {
         public static SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-D66FKKU\\DANGELMSSQL;Initial Catalog=Base_de_Datos_Software2;Integrated Security=True");

        public static SqlConnection obtenerconexión()
        {
            return Conn;
        }
        // Metodo de Abrir Conexcion
        public static void opencon()
        {
            try
            {
                Conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Metodo de cerrar Conexcion
        public static void cerrarcon()
        {
            if (Conn != null)
            {
                try
                {
                    Conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}

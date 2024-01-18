using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void alphaBlendTextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        
             
 

 
            {
                if (txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("El usuario no debe estar en blanco!...");
                    txtNombre.Focus();
                    return;
                }

                if (txtContraseña.Text.Equals(""))
                {
                    MessageBox.Show("La contraseña no debe estar en blanco!...");
                    txtContraseña.Focus();
                    return;
                }

                DataTable dt = new DataTable();
                string consulta;
                consulta = "select * from Usuario where Nombre = @Nombre AND Contraseña = @Contraseña";
                CONEXION.opencon();
                SqlDataAdapter da = new SqlDataAdapter(consulta, CONEXION.obtenerconexión());
                CONEXION.cerrarcon();

                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 20).Value = txtNombre.Text;
                da.SelectCommand.Parameters.Add("@Contraseña", SqlDbType.VarChar, 50).Value = txtContraseña.Text;

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    PERMISOS.Registrar = Convert.ToBoolean(dt.Rows[0][3]);
                    PERMISOS.Consultar = Convert.ToBoolean(dt.Rows[0][4]);
                    PERMISOS.Su = Convert.ToBoolean(dt.Rows[0][5]);

                    Form principal = new Interfaz ();
                    principal.Show();
                    principal.Visible = true;
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto");
                    txtContraseña.Focus();

                }
                CONEXION.cerrarcon();
            }



             }
    }

    


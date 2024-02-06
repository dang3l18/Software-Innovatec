using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Interfaz : Form
    {
        //Fields
        private int borderSize = 2;
        public Interfaz()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//Border Size
            this.BackColor = Color.FromArgb(98, 102, 244);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Panelmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void IconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconRestaurar.Visible = true;
            IconMaximizar.Visible = false;
        }

        private void IconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconRestaurar.Visible = false;
            IconMaximizar.Visible = true;
        }

        private void PanelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Paneltitlebar_MouseDown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Paneltitlebar_MouseDown_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;

        if (m.Msg== WM_NCCALCSIZE && m.WParam.ToInt32 () == 1)

            {

                return;
            }

            base.WndProc(ref m);
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form principal = new Inventario();
            principal.Show();
            principal.Visible = true;
            Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form principal = new Facturacion();
            principal.Show();
            principal.Visible = true;
            Visible = false;
        }
    }
}

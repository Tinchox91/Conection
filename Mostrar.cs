using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatos_Conectada
{
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vt1 prin = new vt1();
            prin.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dato = textBox1.Text;
            cargarTabla(dato);
        }
        private void cargarTabla(string dato)
        {
            List<Escuela> lista = new List<Escuela>();
            ControllerEscuela con = new ControllerEscuela();
            tabla.DataSource = con.consulta(dato);
        }
    }
}

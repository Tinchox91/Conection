using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatos_Conectada
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Conection conect = new Conection();
            conect.conexion();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new vt1());
           
        }
    }
}

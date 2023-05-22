using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        Logica logica = new Logica();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        { 
            Rtxtb_Pantalla.Text = "Avvio del debug\n\n";
            Rtxtb_Pantalla.Text += logica.CrearCadenas(Rtxtb_Codigo.Text);
            Rtxtb_Pantalla.Text += "Debug terminato\n\n";
        }

        private void btn_BorrarPantalla_Click(object sender, EventArgs e)
        {
            Rtxtb_Pantalla.Clear();
        }

        private void btn_BorrarCod_Click(object sender, EventArgs e)
        {
            Rtxtb_Codigo.Clear();
        }

        public void RecibirCadena(String Cadena)
        {
            
        }
    }
}

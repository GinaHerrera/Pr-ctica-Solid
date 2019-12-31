using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBarberia
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }


        private void Registrar_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();

            registrar.Show();
            this.Hide();
        }

        private void Visualizar_Click(object sender, EventArgs e)
        {
            Visualizar ver = new Visualizar();

            ver.Show();
            this.Hide();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

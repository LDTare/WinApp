using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.BD;

namespace WinApp.FD
{
    public partial class Invitado : Form
    {
        public Invitado()
        {
            InitializeComponent();
        }

        BD.ProyectoDataClassesDataContext data = new ProyectoDataClassesDataContext();

        private void Invitado_Load(object sender, EventArgs e)
        {
            Enseres.DataSource = data.ListarEnseres();
            Espacios.DataSource = data.ListarEdificios();
            Edificios.DataSource = data.ListarEspacios();

            var th = from list in data.Insidencias where list.Estado == 1 select list;
            Insidencias.DataSource = th;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

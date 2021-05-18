using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp.FD
{
    public partial class Menu : Form
    {
        public string _usuario;
        public string _rol;

        BD.ProyectoDataClassesDataContext count = new BD.ProyectoDataClassesDataContext();
       


        public Menu()
        {
            InitializeComponent();

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Username.Text = _usuario;
            var inside = from ins in count.TBusers where ins.Usuario == _usuario select ins.ID_Rol;
            var rolIe = from tbs in count.Roles where tbs.ID_Rol == inside.FirstOrDefault() select tbs;

            comboBox1.DataSource = rolIe;
            comboBox1.ValueMember = "ID_Rol";
            comboBox1.DisplayMember = "Nombre_Rol";

            comboBox1.

            string rol;

            switch(rol)
            {
                case "Administrador":
                    {

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FD.Enseres inventario = new Enseres();
            this.Hide();
            inventario.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Close();
        }
    }
}

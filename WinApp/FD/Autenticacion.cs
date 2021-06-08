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
using WinApp.FD;

namespace WinApp.FD
{
    public partial class Autenticacion : Form
    {
        public Autenticacion()
        {
            InitializeComponent();
        }

        BD.ProyectoDataClassesDataContext busers = new ProyectoDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsvalidUser(textBox1.Text, textBox2.Text))

            {
                FD.Menu LogIn = new Menu();

                LogIn._usuario = textBox1.Text;

                LogIn.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario no se encuentra registrado", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }

        }

        private void Autenticacion_Load(object sender, EventArgs e)
        {
        }

        private bool IsvalidUser(string userName, string password)

        {
            BD.ProyectoDataClassesDataContext context = new ProyectoDataClassesDataContext();

            var q = from p in context.TBusers

                    where p.Usuario == textBox1.Text

                    && p.Pass == textBox2.Text

                    select p;



            if (q.Any())
            {
                return true;
            }

            else

            {
                return false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Inicio = new Form1();
            Inicio.Show();
            Close();
        }
    }
}

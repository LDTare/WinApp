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
    public partial class NuevoUser : Form
    {
        public NuevoUser()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Inicio = new Form1();
            Inicio.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BD.ProyectoDataClassesDataContext busers = new ProyectoDataClassesDataContext();

            var count = from rango in busers.TBusers select rango;
            var cantidad = count.Count();

            int i = cantidad;
            i = i + 1;
            try
            {
                busers.Insertar_User("TEMP"+i.ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text), textBox6.Text, 1, "JUBN3", 2);
                MessageBox.Show("Se ha añadido un invitado", "Información");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";

                textBox1.Focus();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

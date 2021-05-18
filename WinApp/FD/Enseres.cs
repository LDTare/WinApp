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
    public partial class Enseres : Form
    {
        public Enseres()
        {
            InitializeComponent();
        }

        BD.ProyectoDataClassesDataContext enseres = new ProyectoDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            string espacio = comboBox1.SelectedValue.ToString();
            string Tipo = comboBox2.Text;

            try
            {
                var count = from rango in enseres.Enseres select rango;
                var cantidad = count.Count();

                i = cantidad + 1;

                enseres.Insertar_Enser(i.ToString(), textBox1.Text, Tipo,espacio);

                textBox1.Clear();
                textBox1.Focus();

                var enseresDB = from tab in enseres.EspacioTB where tab.Estado == 1 select tab;

                comboBox1.DataSource = enseresDB;
                comboBox1.ValueMember = "ID_Espacio";
                comboBox1.DisplayMember = "ID_Espacio";

                var espacios = from txt in enseres.Enseres where txt.Estado == 1 select txt;

                dataGridView1.DataSource = espacios;

                MessageBox.Show("Datos agregados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Enseres_Load(object sender, EventArgs e)
        {
            var enseresDB = from tab in enseres.EspacioTB where tab.Estado == 1 select tab;

            comboBox1.DataSource = enseresDB;
            comboBox1.ValueMember = "ID_Espacio";
            comboBox1.DisplayMember = "ID_Espacio";

            var espacios = from txt in enseres.Enseres where txt.Estado == 1 select txt;

            dataGridView1.DataSource = espacios;
        }
    }
}

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
            string espacio = comboBox1.SelectedValue.ToString();
            string Tipo = comboBox2.Text;

            try
            {
                var count = from rango in enseres.Enseres select rango;
                var cantidad = count.Count();


                enseres.Insertar_Enser(textBox3.Text, textBox1.Text, Tipo,espacio);

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

            comboBox5.DataSource = enseresDB;
            comboBox5.ValueMember = "ID_Espacio";
            comboBox5.DisplayMember = "ID_Espacio";

            var espacios = from txt in enseres.Enseres where txt.Estado == 1 select txt;

            dataGridView1.DataSource = espacios;

            var enseresERD = from tab in enseres.Enseres where tab.Estado == 1 select tab;

            comboBox3.DataSource = enseresERD;
            comboBox3.ValueMember = "ID_Enser";
            comboBox3.DisplayMember = "ID_Enser";

            comboBox6.DataSource = enseresERD;
            comboBox6.ValueMember = "ID_Enser";
            comboBox6.DisplayMember = "ID_Enser";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var id = comboBox3.SelectedValue;
            string espacio = comboBox5.SelectedValue.ToString();
            string Tipo = comboBox4.Text;

            DialogResult resul = MessageBox.Show("¿Desea modificar este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resul == DialogResult.Yes)
            {
                try
                {
                    enseres.Actualizar_Enser(Convert.ToString(id),textBox2.Text,Tipo,1,espacio);

                    textBox2.Clear();
                    textBox2.Focus();

                    var enseresDB = from tab in enseres.Enseres where tab.Estado == 1 select tab;

                    comboBox3.DataSource = enseresDB;
                    comboBox3.ValueMember = "ID_Enser";
                    comboBox3.DisplayMember = "ID_Enser";


                    var enseresDBA = from tab in enseres.EspacioTB where tab.Estado == 1 select tab;

                    comboBox5.DataSource = enseresDBA;
                    comboBox5.ValueMember = "ID_Espacio";
                    comboBox5.DisplayMember = "ID_Espacio";

                    var ListaDatos = from txt in enseres.Enseres where txt.Estado == 1 select txt;

                    dataGridView1.DataSource = ListaDatos;

                    MessageBox.Show("Datos modificados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var id = comboBox3.SelectedValue;
            DialogResult resul = MessageBox.Show("¿Desea Eliminar    este registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resul == DialogResult.Yes)
            {
                try
                {
                    enseres.Eliminar_Enser(Convert.ToString(id), 0);

                    var enseresERD = from tab in enseres.Enseres where tab.Estado == 1 select tab;

                    comboBox3.DataSource = enseresERD;
                    comboBox3.ValueMember = "ID_Enser";
                    comboBox3.DisplayMember = "ID_Enser";

                    comboBox6.DataSource = enseresERD;
                    comboBox6.ValueMember = "ID_Enser";
                    comboBox6.DisplayMember = "ID_Enser";

                    var ListaDatos = from txt in enseres.Enseres where txt.Estado == 1 select txt;

                    dataGridView1.DataSource = ListaDatos;

                    MessageBox.Show("Enser eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reportes frm = new Reportes();
            frm.ShowDialog();
            Close();
        }
    }
}

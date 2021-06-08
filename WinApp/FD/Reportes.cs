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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        BD.ProyectoDataClassesDataContext Report = new ProyectoDataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            var espacios = from TBEspa in Report.EdificioTB where TBEspa.Estado == 1 select TBEspa;

            comboBox1.DataSource = espacios;
            comboBox1.ValueMember = "ID_Edificio";
            comboBox1.DisplayMember = "ID_Edificio";
        }

        private void button2_Click(object sender, EventArgs e)
        {   

            var Ed_ID = comboBox1.SelectedValue;
           string  idEdificio = Convert.ToString(Ed_ID);

            var Lugares = from Listado in Report.EspacioTB where Listado.Estado == 1 where Listado.ID_Edificio == idEdificio  select Listado;
            dataGridView1.DataSource = Lugares;

            comboBox2.DataSource = Lugares;
            comboBox2.ValueMember = "ID_Espacio";
            comboBox2.DisplayMember = "ID_Espacio";

            var enseres = from TDRED in Report.Enseres where TDRED.ID_Espacio == Lugares.FirstOrDefault().ID_Espacio select TDRED;
            dataGridView2.DataSource = enseres;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Ed_ID = comboBox2.SelectedValue;
            string idEdificio = Convert.ToString(Ed_ID);

            var enseres = from TDRED in Report.Enseres where TDRED.ID_Espacio == idEdificio select TDRED;
            dataGridView2.DataSource = enseres;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var Ed_ID = textBox1.Text;
                string idEdificio = Convert.ToString(Ed_ID);
                var enseres = from TDRED in Report.Enseres where TDRED.ID_Enser == idEdificio where TDRED.Estado == 1 select TDRED;
                dataGridView2.DataSource = enseres;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.FD;

namespace WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Cerrar aplicación 
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se creara un usuario temporal hasta que un administrador le asigne un rol","Información",MessageBoxButtons.OK);
            FD.NuevoUser AddTemp = new NuevoUser();
            this.Hide();
            AddTemp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LDT about = new LDT();
            about.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FD.Autenticacion UserLog = new Autenticacion();
            this.Hide();
            UserLog.ShowDialog();
        }
    }
}

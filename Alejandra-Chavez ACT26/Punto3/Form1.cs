using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto3
{
    public partial class Form1 : Form
    {
        /*3. Solicitar el ingreso del nombre de una persona y seleccionar de un control
ComboBox un país. Al presionar un botón mostrar en la barra del título del
Form el nombre ingresado y el país seleccionado.*/
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            Text = text1 + " , " + comboBox1.Text;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

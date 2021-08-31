using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp01
{
    public partial class FrmSuma : Form
    {
        public FrmSuma()
        {
            InitializeComponent();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();//Cierra los forms y sale de la aplicación
        }

        private void SumarButton_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            int suma;
            numero1 = int.Parse(Numero1TextBox.Text);//Tomo el contenido de la prop Text del cuadro de texto
            numero2 = int.Parse(Numero2TextBox.Text);
            suma = numero1 + numero2;
            MessageBox.Show($"La suma es {suma}","Resultado",MessageBoxButtons.OK,MessageBoxIcon.Information);

            SumasListBox.Items.Add(suma);

            InicializarControles();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            Numero1TextBox.Clear();
            Numero2TextBox.Clear();
            Numero1TextBox.Focus();
        }
    }
}

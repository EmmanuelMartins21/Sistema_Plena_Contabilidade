using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Plena_Contabilidade
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

  
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonPessoal_Click(object sender, EventArgs e)
        {
            // Cria um formulario do tipo relacionado e chama sua apresentação
            formPessoal f = new formPessoal();
            f.ShowDialog();
        }

        private void buttonPlena_Click(object sender, EventArgs e)
        {
            // Cria um formulario do tipo relacionado e chama sua apresentação
            FormPlena f = new FormPlena();
            f.ShowDialog();
        }

        private void buttonSSVP_Click(object sender, EventArgs e)
        {
            // Cria um formulario do tipo relacionado e chama sua apresentação
            FormSSVP f = new FormSSVP();
            f.ShowDialog();

        }
    }
}

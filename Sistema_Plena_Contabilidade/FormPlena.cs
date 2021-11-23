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
    public partial class FormPlena : Form
    {
        public FormPlena()
        {
            InitializeComponent();
        }

        //EMISSÃO DAS 
       private void buttonPlena_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www8.receita.fazenda.gov.br/SimplesNacional/Aplicacoes/ATSPO/pgmei.app/Identificacao");
        }

        private void buttonRelacaoClientes_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("");
        }

        private void buttonDASN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gov.br/empresas-e-negocios/pt-br/empreendedor/copy_of_servicos-para-mei/declaracao-anual-de-faturamento");
        }

        private void buttonCCMEI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www22.receita.fazenda.gov.br/inscricaomei/private/pages/certificado_acesso.jsf");
        }

        private void buttonMEI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sso.acesso.gov.br/login?client_id=redesim.gov.br&authorization_id=17c42044f6b");
        }

        private void buttonOcupacaoMEI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gov.br/empresas-e-negocios/pt-br/empreendedor/quero-ser-mei/atividades-permitidas");
        }

        private void buttonPastaCliente_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/11Zix1DwCGUhK-DNjS5mwq4ELGJQOsF1-");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/11Zix1DwCGUhK-DNjS5mwq4ELGJQOsF1-");

            }
            catch(Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

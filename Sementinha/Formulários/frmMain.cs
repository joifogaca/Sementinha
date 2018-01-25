using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sementinha
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Primeiro lê as variáveis de inicialização(nome do servidor, a pasta de relatórios, etc.)
            INI.fncInicializaINI();

            //Frequentadores.Código = 2;
            //int teste = Frequentadores.Código;
            //teste = teste + 1;

        }

        private void btnFrequentadores_Click(object sender, EventArgs e)
        {
          //  Funções.fncConverteControle_Classe("data_alteração");
            frmFrequentadoresIHM frmFREQUENTADORES_1 = new frmFrequentadoresIHM();
            frmFREQUENTADORES_1.Show();

        }

        private void btnTipos_Cadastros_Click(object sender, EventArgs e)
        {
            frmTipos_CadastrosIHM frmTipos_Cadastros_1 = new frmTipos_CadastrosIHM();
            frmTipos_Cadastros_1.Show();
        }
    }
}

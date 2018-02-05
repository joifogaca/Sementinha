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
    public partial class frmFrequentadores : Form
    {

        //Frequentadores umFrequentador = new Frequentadores();

        //public Frequentadores UmFrequentador
        //{
        //    get { return umFrequentador; }
        //    set { umFrequentador = value; }
        //}

        public frmFrequentadores()
        {
            InitializeComponent();
        }

        private void FrequentadoresIHM_Load(object sender, EventArgs e)
        {
            
            bdsFREQUENTADORES = Reflection_Tabela.LL_DataGrid_Genérico("Código, Nome", "Frequentadores");
            dgvFREQUENTADORES.DataSource = bdsFREQUENTADORES;
         
        }

        private void btnFREQUENTADORESincluir_Click(object sender, EventArgs e)
        {
            frmFrequentadoresFicha_Criança frmFREQUENTADORES_criança_incluir = new frmFrequentadoresFicha_Criança();
            frmFREQUENTADORES_criança_incluir.Show();
        }

        private void btnFREQUENTADORESalterar_Click(object sender, EventArgs e)
        {     
            // Cria uma instância do formulário
            frmFrequentadoresFicha_Criança frmFREQUENTADORES_criança_alterar = new frmFrequentadoresFicha_Criança();
            
            // Passa para o fomulário ficha o código do Frequentador a ser carregado
            frmFREQUENTADORES_criança_alterar.Código = Int64.Parse(dgvFREQUENTADORES[0, dgvFREQUENTADORES.CurrentCell.RowIndex].Value.ToString());

            // Estabelece para qual finalidade foi chamado o formulário(nesse caso foi pra alteração), essa variável será útil no outro formulário
            frmFREQUENTADORES_criança_alterar.Status = "A";
            
            // Abre o formulário
            frmFREQUENTADORES_criança_alterar.Show();
            
        }

        private void btnFREQUENTADORESconsultar_Click(object sender, EventArgs e)
        {

        }

       

       

       
    }
}

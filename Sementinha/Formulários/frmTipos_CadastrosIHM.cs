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
    public partial class frmTipos_CadastrosIHM : Form
    {

        //Tipos_Cadastros umTipo_Cadastro = new Tipos_Cadastros();

        //public Tipos_Cadastros UmTipo_Cadastro
        //{
        //    get { return umTipo_Cadastro; }
        //    set { umTipo_Cadastro = value; }
        //}

        public frmTipos_CadastrosIHM()
        {
            InitializeComponent();
        }

        private void Tipos_CadastrosIHM_Load(object sender, EventArgs e)
        {
            //for (int i = 20; i < 32000; i++ )
            //{
            //    AFDAL.ExecuteNonQuery("INSERT INTO Tipos_Cadastros(Código,Nome) VALUES (" + i  + ",'Nome" + i + "')");
            //}

            bdsTIPOS_CADASTROS = Reflection.LL_DataGrid_Genérico("Código, Descrição", "Tipos_Cadastros");
            dgvTIPOS_CADASTROS.DataSource = bdsTIPOS_CADASTROS;
         
        }

        private void btnTIPOS_CADASTROSincluir_Click(object sender, EventArgs e)
        {
            frmTipos_CadastrosFicha_CriançaIHM frmTIPOS_CADASTROS_criança_incluir = new frmTipos_CadastrosFicha_CriançaIHM();
            frmTIPOS_CADASTROS_criança_incluir.Show();
        }

        private void panTIPOS_CADASTROS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTIPOS_CADASTROSalterar_Click(object sender, EventArgs e)
        {     
            // Cria uma instância do formulário
            frmTipos_CadastrosFicha_CriançaIHM frmTIPOS_CADASTROS_criança_alterar = new frmTipos_CadastrosFicha_CriançaIHM();

            // Passa para o fomulário ficha o código do Frequentador a ser carregado
            frmTIPOS_CADASTROS_criança_alterar.Código = Int64.Parse(dgvTIPOS_CADASTROS[0, dgvTIPOS_CADASTROS.CurrentCell.RowIndex].Value.ToString());

            // Estabelece para qual finalidade foi chamado o formulário(nesse caso foi pra alteração), essa variável será útil no outro formulário
            frmTIPOS_CADASTROS_criança_alterar.Status = "A";
            
            // Abre o formulário
            frmTIPOS_CADASTROS_criança_alterar.Show();
            
        }

  

       

       

       
    }
}

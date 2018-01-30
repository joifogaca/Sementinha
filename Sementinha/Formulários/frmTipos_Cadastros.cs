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
    public partial class frmTipos_Cadastros : Form
    {
    
        public frmTipos_Cadastros()
        {
            InitializeComponent();
        }

        private void Tipos_CadastrosIHM_Load(object sender, EventArgs e)
        {

            bdsTIPOS_CADASTROS = Reflection_Tabela.LL_DataGrid_Genérico("Código, Descrição", this.GetType().Name.Substring(3, this.GetType().Name.Length - 3));
            dgvTIPOS_CADASTROS.DataSource = bdsTIPOS_CADASTROS;     
         
        }

        private void btn_genérico_Click(object sender, EventArgs e)
        {
            
            //Instancia o formulário
            frmTipos_CadastrosFichaIHM UmFormulário = new frmTipos_CadastrosFichaIHM();
         
            //Retirando as três primeiras letras do nome do formulário, obteremos o nome da classe
            UmFormulário.Formulário.Nome_classe = this.GetType().Name.Substring(3, this.GetType().Name.Length - 3);

            //Exemplos: btnTIPOS_CADASTROSincluir, retorna 'I', btnTIPOS_CADASTROSalterar, retorna 'A' e assim por diante
            UmFormulário.Formulário.Status = Funções.fncRetornaNomePropriedade(UmFormulário.Formulário.Nome_classe, 
                                                                            (sender as Button).Name)  //O segundo parâmetro manda o nome do botão Exemplo: btnTIPOS_CADASTROSincluir
                                                                            .Substring(0,1)
                                                                            .ToUpper();

            //Armazena o código do registro a ser alterado/consultado ou excluído
            if (UmFormulário.Formulário.Status != "I") UmFormulário.Formulário.Código = Int64.Parse(dgvTIPOS_CADASTROS[0, dgvTIPOS_CADASTROS.CurrentCell.RowIndex].Value.ToString());

            //Abre o formulário
            UmFormulário.Show();

        }        
       
    }
}

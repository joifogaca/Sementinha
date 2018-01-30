using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Sementinha
{
    public partial class frmTipos_CadastrosFicha : Form
    {       
        public Formulários Formulário = new Formulários();

        public frmTipos_CadastrosFicha()
        {
            InitializeComponent();
        }


        private void Tipos_CadastrosFicha_CriançaIHM_Load(object sender, EventArgs e)
        {
            if (Reflection_BLL.Acha_Campo_Identity("Tipos_Cadastros") == "Código")
            {
                txtTIPOS_CADASTROScódigo.Enabled = false;
            }

            if (Formulário.Status == "A")
            {     
                // Carrega os campos dos formulários
                Reflection_Formulário.Attr_Formulário_Genérico(panTIPOS_CADASTROSFicha,
                                                               Reflection_Tabela.RT_Tabela_Genérico(Código, "Tipos_Cadastros"));
            }
        }

        private void btnTIPOS_CADASTROSok_Click(object sender, EventArgs e)
        {
            object Tipos_Cadastros;

            if (Status == "I")
            {
                // Tipos_Cadastros_Criança recebe um objeto da classe Tipos_Cadastros 
                Tipos_Cadastros = Reflection_Classe.IN_Classe_Genérico(panTIPOS_CADASTROSFicha);

                // Insere o registro no banco de dados 
                Reflection_Tabela.IN_Tabela_Genérico(Tipos_Cadastros);
            }
            else
            {
                // Tipos_Cadastros_Criança recebe um objeto da classe Tipos_Cadastros 
                Tipos_Cadastros = Reflection_Classe.IN_Classe_Genérico(panTIPOS_CADASTROSFicha);

                // Atualiza o registro na tabela do banco dedados
                Reflection_Tabela.UP_Tabela_Genérico(Tipos_Cadastros, "Código");

            }

            //Fecha o formulário
            this.Close();

        }

      
          
          

       
    }
}

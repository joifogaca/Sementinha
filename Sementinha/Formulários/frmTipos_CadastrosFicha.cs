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
    public partial class frmTipos_CadastrosFichaIHM : Form
    {
        Formulários formulário = new Formulários();

        internal Formulários Formulário
        {
            get { return formulário; }
            set { formulário = value; }
        }

        public frmTipos_CadastrosFichaIHM()
        {
            InitializeComponent();
        }

        private void Tipos_CadastrosFicha_CriançaIHM_Load(object sender, EventArgs e)
        {
            if (Reflection_BLL.Acha_Campo_Identity(formulário.Nome_classe) == "Código")
            {
                txtTIPOS_CADASTROScódigo.Enabled = false;
            }

            if (formulário.Status != "I") 
            {     
                // Carrega os campos dos formulários
                Reflection_Formulário.Attr_Formulário_Genérico(panTIPOS_CADASTROSFicha,
                                                               Reflection_Tabela.RT_Tabela_Genérico(formulário.Código, formulário.Nome_classe));
            }
        }

        private void btnTIPOS_CADASTROSok_Click(object sender, EventArgs e)
        {          
            switch (formulário.Status)
            {
                case "I":
                    Reflection_Tabela.IN_Tabela_Genérico(Reflection_Classe.IN_Classe_Genérico(panTIPOS_CADASTROSFicha));
                    break;
                case "A":
                    Reflection_Tabela.UP_Tabela_Genérico(Reflection_Classe.IN_Classe_Genérico(panTIPOS_CADASTROSFicha), "Código");
                    break;
            }            
         
            //Fecha o formulário
            this.Close();
        }

      
          
          

       
    }
}

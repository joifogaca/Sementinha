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
            
            this.Text = Reflection_Formulário.Inicializa_Formulário_Genérico(panTIPOS_CADASTROSFicha, formulário);        

            if (formulário.Status != "I") 
            {     
                // Carrega os valores dos campos dos formulários
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
                case "E":
                    Reflection_Tabela.EX_Tabela_Genérico(formulário);
                    break;
            }            
         
            //Fecha o formulário
            this.Close();
        }

      
          
          

       
    }
}

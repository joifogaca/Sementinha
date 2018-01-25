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
    public partial class frmTipos_CadastrosFicha_CriançaIHM : Form
    {
        Tipos_Cadastros umTipo_Cadastro = new Tipos_Cadastros();
        private string status;
        private long código;

        public long Código
        {
            get { return código; }
            set { código = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
         
        public frmTipos_CadastrosFicha_CriançaIHM()
        {
            InitializeComponent();
        }


        private void Tipos_CadastrosFicha_CriançaIHM_Load(object sender, EventArgs e)
        {       
            if (Status == "A")
            {                 
                umTipo_Cadastro = (Tipos_Cadastros)Reflection.RT_Formulário_Genérico(Código,"Tipos_Cadastros");
                Reflection.Attr_Formulário_Genérico(panTIPOS_CADASTROSFicha, umTipo_Cadastro);
            }
        }

        private void btnTIPOS_CADASTROSok_Click(object sender, EventArgs e)
        {
            object Tipos_Cadastros;

            // Tipos_Cadastros_Criança recebe um objeto da classe Tipos_Cadastros 
            Tipos_Cadastros = Reflection.IN_Classe_Genérico(panTIPOS_CADASTROSFicha);

            // Armazena os dados no banco de dados 
            Reflection.IN_Formulário_Genérico(Tipos_Cadastros, "IN");
        }

  
   

      
          
          

       
    }
}

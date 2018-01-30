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
    public partial class frmFrequentadoresFicha_Criança : Form
    {
        Frequentadores umFrequentador = new Frequentadores();
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
         
        public frmFrequentadoresFicha_Criança()
        {
            InitializeComponent();
        }

        private void btnFREQUENTADORESok_Click(object sender, EventArgs e)
        {
         //   FrequentadoresBLL.validaDados();

            
            object Frequentadores_Criança;

            // Frequentadores_Criança recebe um objeto da classe Frequentadores 
            Frequentadores_Criança =  Reflection_Classe.IN_Classe_Genérico(panFREQUENTADORESFicha);
            
            // Armazena os dados no banco de dados 
            Reflection_Tabela.IN_Tabela_Genérico(Frequentadores_Criança);

            //Fecha o formulário
            this.Close();

        }

        private void FrequentadoresFicha_CriançaIHM_Load(object sender, EventArgs e)
        {       
            if (Status == "A")
            {                 
                umFrequentador = (Frequentadores)Reflection_Tabela.RT_Tabela_Genérico(Código,"Frequentadores");
                Reflection_Formulário.Attr_Formulário_Genérico(panFREQUENTADORESFicha, umFrequentador);
            }
        }

        private void panFREQUENTADORESFicha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFREQUENTADORESpesquisar_nome_mãe_Click(object sender, EventArgs e)
        {

        }        
          

       
    }
}

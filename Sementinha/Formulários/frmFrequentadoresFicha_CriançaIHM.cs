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
    public partial class frmFrequentadoresFicha_CriançaIHM : Form
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
         
        public frmFrequentadoresFicha_CriançaIHM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grpFREQUENTADORESsexo_Enter(object sender, EventArgs e)
        {

        }

        private void panFREQUENTADORESFicha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFREQUENTADORESok_Click(object sender, EventArgs e)
        {
            object Frequentadores_Criança;

            // Frequentadores_Criança recebe um objeto da classe Frequentadores 
            Frequentadores_Criança =  Reflection.IN_Classe_Genérico(panFREQUENTADORESFicha);
            
            // Armazena os dados no banco de dados 
            Reflection.IN_Formulário_Genérico(Frequentadores_Criança, "IN");

        }

        private void FrequentadoresFicha_CriançaIHM_Load(object sender, EventArgs e)
        {       
            if (Status == "A")
            {                 
                umFrequentador = (Frequentadores)Reflection.RT_Formulário_Genérico(Código,"Frequentadores");
                Reflection.Attr_Formulário_Genérico(panFREQUENTADORESFicha, umFrequentador);
            }
        }
          
          

       
    }
}

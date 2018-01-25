using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sementinha
{
    class Escolaridades
    {
        // SEMPRE COLOCAR AS PROPRIEDADES NA MESMA ORDEM QUE AS COLUNAS ESTÃO NA TABELA 

        private int código;
        private string escolaridade;
        private int ano;
        private string período;

        public int Código
        {
            get { return código; }
            set { código = value; }
        }

        public string Escolaridade
        {
            get { return escolaridade; }
            set { escolaridade = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string Período
        {
            get { return período; }
            set { período = value; }
        }

        public string insereRegistro_ComboBox()
        {
            return código + " " + escolaridade + " " + ano + " " + período;
        }
        
        
    }
}

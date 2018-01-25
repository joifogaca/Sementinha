using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sementinha
{
    class Parentescos
    {

        // SEMPRE COLOCAR AS PROPRIEDADES NA MESMA ORDEM QUE AS COLUNAS ESTÃO NA TABELA 

        private int código;
        private string descrição;
        private int[] relação_código_combobox;
        
        public string Descrição
        {
            get { return descrição; }
            set { descrição = value; }
        }

        public int Código
        {
            get { return código; }
            set { código = value; }
        }

        public int[] Relação_Código_Combobox
        {
            get { return relação_código_combobox; }
            set { relação_código_combobox = value; }
        }
    }
}

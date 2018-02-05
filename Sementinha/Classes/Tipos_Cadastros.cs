using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sementinha
{
    class Tipos_Cadastros
    {

        // SEMPRE COLOCAR AS PROPRIEDADES NA MESMA ORDEM QUE AS COLUNAS ESTÃO NA TABELA 

        private int código;
        private string descrição;       
  
        public int Código
        {
            get { return código; }
            set { código = value; }
        }

        public string Descrição
        {
            get { return descrição; }
            set { descrição = value; }
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sementinha
{
    class Tipos_Cadastros
    {

        // SEMPRE COLOCAR AS PROPRIEDADES NA MESMA ORDEM QUE AS COLUNAS ESTÃO NA TABELA 

        private static int código;
        private static string descrição;
  
        public static int Código
        {
            get { return Tipos_Cadastros.código; }
            set { Tipos_Cadastros.código = value; }
        }

        public static string Descrição
        {
            get { return Tipos_Cadastros.descrição; }
            set { Tipos_Cadastros.descrição = value; }
        }

    }
}

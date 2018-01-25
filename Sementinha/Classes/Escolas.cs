using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sementinha
{
    class Escolas
    {
        // SEMPRE COLOCAR AS PROPRIEDADES NA MESMA ORDEM QUE AS COLUNAS ESTÃO NA TABELA 

        private static int código;
        private static string nome;
        private static string cep;
        private static string complemento;

        public static string Complemento
        {
            get { return Escolas.complemento; }
            set { Escolas.complemento = value; }
        }

        public static string CEP
        {
            get { return Escolas.cep; }
            set { Escolas.cep = value; }
        }

        public static string Nome
        {
            get { return Escolas.nome; }
            set { Escolas.nome = value; }
        }

        public static int Código
        {
            get { return Escolas.código; }
            set { Escolas.código = value; }
        } 

    }
}

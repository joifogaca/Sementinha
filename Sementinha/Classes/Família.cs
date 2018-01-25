using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sementinha
{
    class Família
    {
        // SEMPRE COLOCAR AS PROPRIEDADES NA MESMA ORDEM QUE AS COLUNAS ESTÃO NA TABELA 

        private static int código;
        private static int quantidade_cesta_básica;
        private static string situação;
        private static string observações;
        private static DateTime data_início_recebimento;
        private static DateTime data_inclusão;

        public static int Código
        {
            get { return Família.código; }
            set { Família.código = value; }
        }

        public static int Quantidade_Cesta_Básica
        {
            get { return Família.quantidade_cesta_básica; }
            set { Família.quantidade_cesta_básica = value; }
        }

        public static string Situação
        {
            get { return Família.situação; }
            set { Família.situação = value; }
        }
        

        public static string Observações
        {
            get { return Família.observações; }
            set { Família.observações = value; }
        }
        

        public static DateTime Data_Início_Recebimento
        {
            get { return Família.data_início_recebimento; }
            set { Família.data_início_recebimento = value; }
        }
        

        public static DateTime Data_Inclusão
        {
            get { return Família.data_inclusão; }
            set { Família.data_inclusão = value; }
        }
       


    }
}

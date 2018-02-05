using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sementinha
{
    class Funções
    {
        public static string fncRetornaNomePropriedade(string Nome_Classe, string Nome_Controle)
        {   //Exemplo: Classe: Frequentadores | Controle: txtFREQUENTADORESdata_nascimento >>>> Retorna: data_nascimento
            
            return Nome_Controle.Substring(3 + Nome_Classe.Length,
                                           Nome_Controle.Length - 3 - Nome_Classe.Length);
        }

        // Função que retorna apenas os caracteres que estão maiúsculos da string
        public static string fncRetornaParteMaiúscula(String Texto)
        {
            string Auxiliar = "";
            string Comparação = Texto.ToUpper();
            for (int i = 0; i < Texto.Length; i++ )
            {
                if (Texto[i] == Comparação[i])

                    // Se for VERDADEIRO a comparação, significa que a letra está maiúscula
                    Auxiliar = Auxiliar + Texto[i].ToString();
            }

            // Se retornar "FREQUENTADORES_", retira o "_" para ficar "FREQUENTADORES"
            // Se retornar "CESTAS_BÁSICAS", não vai ser retirado o "_" e manterá o "CESTAS_BÁSICAS"
            if (Auxiliar.IndexOf('_') + 1 == Auxiliar.Length)             
                Auxiliar = Auxiliar.Replace("_", "");   

            return Auxiliar;
        }


        public static string fncConverteControle_Classe(string Texto)
        {            
            string Auxiliar = "";           
            string[] Delimitador;

            Delimitador = Texto.Split('_');

            for (int i = 0; i < Delimitador.Length; i++)
            {
                Delimitador[i] = Delimitador[i].Substring(0, 1).ToUpper() + Delimitador[i].Substring(1, Delimitador[i].Length - 1);
                Auxiliar = Auxiliar + Delimitador[i] + "_";
            }

            Auxiliar = Auxiliar.Substring(0, Auxiliar.Length - 1);                    

            return Auxiliar;
        }

       
    }
}

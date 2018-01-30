using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;

namespace Sementinha
{
    class ALDAL
    {
        public static void atualizaDados_Genérico(string Tabela, string Valores, string Where)
        {
            string TextoSQL;

            TextoSQL = "UPDATE " + Tabela + " SET " + Valores + " WHERE " + Where;

            AFDAL.ExecuteNonQuery(TextoSQL);  
        }

        public static void insereDados_Genérico(string Tabela, string Parâmetros, string Valores)
        {
            string TextoSQL;            

            TextoSQL = "INSERT INTO " + Tabela + "(" + Parâmetros + ") VALUES(" + Valores + ")";

            AFDAL.ExecuteNonQuery(TextoSQL);            
        }

        public static void buscaDados_Genérico(long Código, string Tabela)
        {
            string TextoSQL;

            TextoSQL = "EXECUTE Principal_RT_Genérico " +
                        Código +
                        ",'" + Tabela + "'";
            AFDAL.ExecuteQuery(TextoSQL);
        }
      
        public static void selecionaDados_Genérico(string Parâmetros, string Tabela)
        {
            string TextoSQL;           

            TextoSQL = "EXECUTE Principal_LL_Genérico " +
                        "'" + Parâmetros + "'" +
                        ",'" + Tabela + "'";

            AFDAL.ExecuteQuery(TextoSQL);         
        }

        public static void LL_Genérico(string Parâmetros, string Tabela)
        {
            string TextoSQL;         
       
            TextoSQL = "EXECUTE Principal_LL_Genérico " +
                        "'" + Parâmetros + "'" +
                        ",'" + Tabela + "'";

            //Essa variável armazenerá temporiamente o resultado da query
            AFDAL.ExecuteQuery_Reader(TextoSQL);
        }

        public static void lêUm_Registro(object Classe_Genérica)
        {
            AFDAL.LêUmRegistro(Classe_Genérica);
        }

        // NÃO ESTÁ SENDO UTILIZADO
        public static void gravaDados_Genérico(object Classe_Genérica, string Status) // Este método pegará todos os dados do formulário a partir de um objecto de uma classe instanciada e incluirá na tabela
        {
            string TextoSQL;
            string Tipo_Propriedade;

            TextoSQL = "EXECUTE Principal_" + Status + "_" + Classe_Genérica.GetType().Name + " ";

            // Retorna todas as propriedades da classe em forma de Array
            PropertyInfo[] Propriedades_Genéricas = Classe_Genérica.GetType().GetProperties();

            for (int i = 0; i < Propriedades_Genéricas.Length; i++)
            {               
                Tipo_Propriedade = Propriedades_Genéricas[i].PropertyType.Name;

                // Se a propriedade for string, char, byte ou data, é necessário que o valor esteja entre aspa simples para formar o Texto do SQL
                if (Tipo_Propriedade.ToUpper() == "BYTE" || Tipo_Propriedade.ToUpper() == "STRING" || Tipo_Propriedade.ToUpper() == "CHAR")
                   
                    TextoSQL = TextoSQL + "'" + Propriedades_Genéricas[i].GetValue(Classe_Genérica, null) + "',";

                else if (Tipo_Propriedade.ToUpper() == "DATETIME")
                {
                    // A data é formatada neste padrão para que seja aceito pelo SQL Server
                    TextoSQL = TextoSQL + "'" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", Propriedades_Genéricas[i].GetValue(Classe_Genérica, null)) + "', ";            
                }
                else
                    // Para as propriedades do tipo Int e Long não é necessário das aspas simples
                    TextoSQL = TextoSQL + Propriedades_Genéricas[i].GetValue(Classe_Genérica, null) + ", ";          
           
            }         

            // Executa o comando sql
            AFDAL.ExecuteNonQuery(TextoSQL.Substring(0, TextoSQL.Length -1));
        }
    }
}

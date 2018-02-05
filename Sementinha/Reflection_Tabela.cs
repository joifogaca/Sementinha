using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Sementinha
{
    class Reflection_Tabela
    {
     //   private static object Instância_Genérica;
        private static PropertyInfo Propriedade_Genérica;

        public static BindingSource LL_DataGrid_Genérico(string Parâmetros, string Tabela)
        {
            //Executa o select
            ALDAL.Seleciona_Registros_Genérico(Parâmetros, Tabela);

            BindingSource bdsGenérico = new BindingSource();

            //Carrega o datagridview com o resultado do select 
            bdsGenérico.DataSource = AFDAL.DtSementinha;

            //e passa para o formulário de volta
            return bdsGenérico;
        }

        public static object RT_Tabela_Genérico(long Código, string Tabela)
        {
            string Nome_Campo;
            object Instância_Genérica;

            // Busca o registro na tabela
            ALDAL.Busca_Registro_Genérico(Código, Tabela);

            // Instancia a classe
            Instância_Genérica = Reflection.InstanciaClasse(Tabela);

            for (int i = 0; i < AFDAL.DtSementinha.Columns.Count; i++)
            {
                // Descobre de qual propriedade da classe o controle atual pertence
                Nome_Campo = AFDAL.DtSementinha.Columns[i].ColumnName;            

                try
                {
                    // Permite acessar a propriedade em questão
                    Propriedade_Genérica = Instância_Genérica.GetType().GetProperty(Nome_Campo);

                    // Método que insere na propriedade da classe instanciada o valor que está no controle
                    Reflection_Classe.IN_Propriedade_Genérico(Propriedade_Genérica, AFDAL.DtSementinha.Rows[0][i].ToString(), Instância_Genérica);
                }
                catch (Exception Erro)
                {
                }                   
            }
            return Instância_Genérica;
        }

        public static void EX_Tabela_Genérico(Formulários Formulário)
        {
            ALDAL.Exclui_Registro_Genérico(Formulário.Nome_classe, "Código=" + Formulário.Código);
        }


        public static void UP_Tabela_Genérico(object Instância_Genérica, string TextoWHERE)
        {
            string Tabela, Parâmetros_Valores = "",Campo_Identity;    

            // Retorna o nome da Classe(que é o mesmo nome da Tabela)
            Tabela = Instância_Genérica.GetType().Name;

            // Verifica se tem algum campo que é identity
            Campo_Identity = Reflection_BLL.Acha_Campo_Identity(Tabela);

            // Cria uma array de propriedades que pertencem a classe
            PropertyInfo[] Propriedades_Genéricas = Instância_Genérica.GetType().GetProperties();

             //Percorre todas as propriedades da classe
            for (int i = 0; i < Propriedades_Genéricas.Length; i++)
            {        
                //Constrói o WHERE do UPDATE
                if (TextoWHERE == Propriedades_Genéricas[i].Name)
                    TextoWHERE = Propriedades_Genéricas[i].Name + "=" +
                                     Retorna_ValorPropriedade_Genérico(Propriedades_Genéricas[i].PropertyType.Name,
                                                               Propriedades_Genéricas[i].GetValue(Instância_Genérica, null));

                // Se o campo for identity(auto incrementado), não há necessidade de inserir no SET do UPDATE
                if (Campo_Identity == Propriedades_Genéricas[i].Name) i = i + 1;

                //Constrói o SET do UPDATE
                Parâmetros_Valores = Parâmetros_Valores + 
                                     Propriedades_Genéricas[i].Name + "=" +
                                     Retorna_ValorPropriedade_Genérico(Propriedades_Genéricas[i].PropertyType.Name,
                                                               Propriedades_Genéricas[i].GetValue(Instância_Genérica, null))                                                                + ",";
             
            }

            //Retira o último caractere que é a vígula
            Parâmetros_Valores = Parâmetros_Valores.Substring(0, Parâmetros_Valores.Length - 1);

            //Finalmente atualiza o registro na tabela
            ALDAL.Atualiza_Registo_Genérico(Tabela, Parâmetros_Valores, TextoWHERE);
        }      

        public static void IN_Tabela_Genérico(object Instância_Genérica)
        {  //Esse funciona no Frequentadores: ALDAL.gravaDados_Genérico(Classe_Genérica, Status);

            string Tabela, Parâmetros = "", Valores = "",Campo_Identity;

            // Retorna o nome da Classe(que é o mesmo nome da Tabela)
            Tabela = Instância_Genérica.GetType().Name;

            // Verifica se tem algum campo que é identity
            Campo_Identity = Reflection_BLL.Acha_Campo_Identity(Tabela);

            // Cria uma array de propriedades que pertencem a classe
            PropertyInfo[] Propriedades_Genéricas = Instância_Genérica.GetType().GetProperties();

            //Percorre todas as propriedades da classe
            for (int i = 0; i < Propriedades_Genéricas.Length; i++)
            {
                // Se o campo for identity(auto incrementado), não há necessidade de inserir no SET do UPDATE
                if (Campo_Identity == Propriedades_Genéricas[i].Name) i = i + 1;

                Parâmetros = Parâmetros + Propriedades_Genéricas[i].Name + ",";

                Valores = Valores + Retorna_ValorPropriedade_Genérico(Propriedades_Genéricas[i].PropertyType.Name,
                                                               Propriedades_Genéricas[i].GetValue(Instância_Genérica, null))
                                                                + ",";

            }
            //Retira o último caractere que é a vígula
            Parâmetros = Parâmetros.Substring(0, Parâmetros.Length - 1);
            Valores = Valores.Substring(0, Valores.Length - 1);

            //Finalmente insere o registro na tabela
            ALDAL.Insere_Registro_Genérico(Tabela, Parâmetros, Valores);
        }

        public static string Retorna_ValorPropriedade_Genérico(string Tipo_Propriedade, object Valor_Propriedade)
        {
            // Se a propriedade for string, char, byte ou data, é necessário que o valor esteja entre aspa simples para formar o Texto do SQL
            if (Tipo_Propriedade.ToUpper() == "BYTE" || Tipo_Propriedade.ToUpper() == "STRING" || Tipo_Propriedade.ToUpper() == "CHAR")
            {
                Valor_Propriedade = "'" + Valor_Propriedade + "'";
            }
            else if (Tipo_Propriedade.ToUpper() == "DATETIME")
            {
                // A data é formatada neste padrão para que seja aceito pelo SQL Server
                Valor_Propriedade = "'" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", Valor_Propriedade) + "', ";
            }

            return Valor_Propriedade.ToString();
        }

       

    }
}

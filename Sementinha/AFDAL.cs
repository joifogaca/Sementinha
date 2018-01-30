using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace Sementinha
{
    class AFDAL
    {
        private static string Nome_do_Servidor = INI.Nome_do_Servidor;
        private static string Usuário = "";
        private static string Senha = "";
        private static string Banco_de_Dados = "Sementinha";

        private static string Conexão = "Data Source=" + Nome_do_Servidor +
                                     //   ";User ID=" + Usuário +
                                     //   ";Password=" + Senha +
                                        ";Initial Catalog=" + Banco_de_Dados +
                                        ";Integrated Security=TRUE";

        // Variável para conexão com o banco de dados
        private static SqlConnection dbSementinha; 

        // Variável que armazena o Comando SQL
        private static SqlCommand cmdSementinha;

        // Variável que forma um DataReader (equivale ao recordset usado no VB6)   
        private static SqlDataReader drSementinha;

        private static SqlDataAdapter daSementinha;

        private static SqlCommandBuilder cmbSementinha;

        private static DataTable dtSementinha;

        public static DataTable DtSementinha
        {
            get { return AFDAL.dtSementinha; }
            set { AFDAL.dtSementinha = value; }
        }
        
        private static DataSet dsSementinha;

        public static DataSet DsSementinha
        {
            get { return AFDAL.dsSementinha; }
            set { AFDAL.dsSementinha = value; }
        }        
        
        public static void ExecuteNonQuery(string TextoSQL)
        {
            try
            {                

                // Instancia a conexão com o banco de dados
                dbSementinha = new SqlConnection(Conexão);

                // Cria o comando SQL
                cmdSementinha = new SqlCommand(TextoSQL, dbSementinha);

                // Abre a conexão com o Banco de Dados
                dbSementinha.Open();

                // Abre o comando e executa a Stored Procedure
                cmdSementinha.ExecuteNonQuery();

                // Fecha a conexão com o Banco de Dados
                dbSementinha.Close();
            }
            catch (Exception Err)
            {
               string teste = Err.Message;
            }
        }

        public static void ExecuteQuery_Reader(string TextoSQL)
        {
            try
            {

                // Instancia a conexão com o banco de dados
                dbSementinha = new SqlConnection(Conexão);

                // Cria o comando SQL
                cmdSementinha = new SqlCommand(TextoSQL, dbSementinha);

                // Abre a conexão com o Banco de Dados
                dbSementinha.Open();

                //Executa o Comando SQL para formar a tabela usando Data Reader
                drSementinha = cmdSementinha.ExecuteReader();

            }
            catch (Exception Err)
            {
                string teste = Err.Message;
            }
        }

        public static object LêUmRegistro(object Classe_Genérica)
        {
            System.Reflection.PropertyInfo Propriedade_Genérica;

            try
            {

                // Se possuir registro
                if (drSementinha.Read())
                {
                    for (int i = 0; i < drSementinha.FieldCount; i++)
                    {
                        // retorna a propriedade
                        Propriedade_Genérica = Classe_Genérica.GetType().GetProperty("" + drSementinha.GetName(i));

                        // seta o valor na classe
                        Reflection_Classe.IN_Propriedade_Genérico(Propriedade_Genérica, drSementinha.GetValue(i),Classe_Genérica);
                    }
                }
                else
                {
                    Erro.setErro(true);
                    drSementinha.Close();
                }
            }

            catch (Exception Err)
            {
                Erro.setErro(Err.Message);
            }

            return Classe_Genérica;
        }

       

        public static void ExecuteQuery(string TextoSQL)
        {
            try
            {

                // Instancia a conexão com o banco de dados
                dbSementinha = new SqlConnection(Conexão);               

                // Abre a conexão com o Banco de Dados
                //dbSementinha.Open();

                // Cria um novo adaptador de dados
                daSementinha = new SqlDataAdapter(TextoSQL, Conexão);

                dtSementinha = new DataTable();
                dtSementinha.Locale = System.Globalization.CultureInfo.InvariantCulture;

                daSementinha.Fill(dtSementinha);                

            }
            catch (Exception Err)
            {
                string teste = Err.Message;
            }
           
        }

     

      

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Data;

namespace Sementinha
{
    class Reflection
    {
        private static object Classe_Genérica;
        private static PropertyInfo Propriedade_Genérica;

        public static Panel Attr_Formulário_Genérico(Panel Panel_Genérico, object Instância_Genérica)
        {
            string Tipo_Campo;
            string Nome_Campo;  

            for (int i = 0; i < Panel_Genérico.Controls.Count; i++)
            {
                // Descobre o tipo do controle (label, textbox, button ou qualquer outro)
                Tipo_Campo = Panel_Genérico.Controls[i].Name.Substring(0, 3);

                // A partir do nome do controle(ex: grpFREQUENTADORESsexo), essa função vai retornar "sexo", que é a propriedade
                Nome_Campo = Funções.fncRetornaNomePropriedade(Instância_Genérica.GetType().Name,Panel_Genérico.Controls[i].Name);

                // Padroniza o nome do campo para ficar igual ao nome da propriedade(ex: De "nome_crachá" Para "Nome_Crachá"
                Nome_Campo = Funções.fncConverteControle_Classe(Nome_Campo);

                // Permite acessar a propriedade em questão
                Propriedade_Genérica = Classe_Genérica.GetType().GetProperty(Nome_Campo);

                // Verifica se o controle em questão, pertence a alguma propriedade da classe
                if (Propriedade_Genérica != null)

                    switch (Tipo_Campo )
                    {
                        case "txt":
                            Attr_TextBox_Genérico(Panel_Genérico.Controls[i]);
                            break;
                        case "cmb":
                            Attr_ComboBox_Genérico(Panel_Genérico.Controls[i]); 
                            break;
                        case "grp":
                            Attr_GroupBox_Genérico(Panel_Genérico.Controls[i]);
                            break;
                    }

            }
            return Panel_Genérico;
        }
        
        public static void Attr_TextBox_Genérico(Control Controle_Genérico)
        {
            Controle_Genérico.Text = Propriedade_Genérica.GetValue(Classe_Genérica, null).ToString();            
        }

        public static void Attr_ComboBox_Genérico(Control Controle_Genérico)
        {
            string Nome_Campo;
            object Item_ComboBox;
            int Contador = 0;    
            ComboBox ComboBox_Genérico = (ComboBox)Controle_Genérico;

            // A partir do nome do controle(ex: grpFREQUENTADORESsexo), essa função vai retornar "sexo", que é a propriedade
            Nome_Campo = Funções.fncRetornaNomePropriedade(Classe_Genérica.GetType().Name, Controle_Genérico.Name);

            // Padroniza o nome do campo para ficar igual ao nome da propriedade(ex: De "nome_crachá" Para "Nome_Crachá"
            Nome_Campo = Funções.fncConverteControle_Classe(Nome_Campo);

            // Instancia o objeto classe
            Classe_Genérica = InstanciaClasse(Nome_Campo);
            
            Type Tipo_Genérico = Classe_Genérica.GetType();

            // Retorna uma coleção de objetos para preencher a combobox
            ALDAL.LL_Genérico("*", Nome_Campo);

            // Lê o primeiro registro do Select
            ALDAL.lêUm_Registro(Classe_Genérica);

            while (Erro.getErro() == false)
            {
                // Invoca o método da classe que compõe a string a ser inserida na combobox 
                Item_ComboBox = Tipo_Genérico.InvokeMember("insereRegistro_ComboBox",
                                               BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance, null, Classe_Genérica, new object[] { });
                
                // Finalmente insere o item na ComboBox
                ComboBox_Genérico.Items.Insert(Contador, Item_ComboBox);

                // Lê o próximo registro do Select
                ALDAL.lêUm_Registro(Classe_Genérica);

                Contador++;
            }          
             }

        public static void Attr_GroupBox_Genérico(Control GroupBox_Genérico)
        {
            if (GroupBox_Genérico.Controls[0].Name.Substring(0, 3) == "rdb")
            {
                Attr_RadioButton_Genérico(GroupBox_Genérico);
            }
        }
        public static void Attr_RadioButton_Genérico(Control GroupBox_Genérico)
        {
            string Nome_Controle;
            RadioButton RadioButton_Genérico;

            for (int i = 0; i < GroupBox_Genérico.Controls.Count; i++)
            {
                Nome_Controle = Funções.fncRetornaNomePropriedade(Classe_Genérica.GetType().Name, GroupBox_Genérico.Controls[i].Name);
                if (Nome_Controle.ToUpper() == Propriedade_Genérica.GetValue(Classe_Genérica, null).ToString())
                {
                    RadioButton_Genérico = (RadioButton)GroupBox_Genérico.Controls[i];
                    RadioButton_Genérico.Checked = true;                    
                }
                break;
            }
        }

        //public static object[] LL_Genérico(string Nome_Tabela)
        //{
        //    object[] Resultado_Query;

        //    //Instancia o objeto da classe
        //    object Classe_Genérico = InstanciaClasse(Nome_Tabela); 
            
        //    //Executa o select de todos os registros da tabela, e devolve uma array de objetos
            

        //    return Coleção_Instância_Genérica;
        //}

        public static BindingSource LL_DataGrid_Genérico(string Parâmetros, string Tabela)
        {
            //Executa o select
            ALDAL.selecionaDados_Genérico(Parâmetros, Tabela);

            BindingSource bdsGenérico = new BindingSource();

            //Carrega o datagridview com o resultado do select 
            bdsGenérico.DataSource = AFDAL.DtSementinha;

            //e passa para o formulário de volta
            return bdsGenérico;
        }     
        
        public static object RT_Formulário_Genérico(long Código, string Tabela)
        {            
            string Nome_Campo;   

            // Busca o registro na tabela
            ALDAL.buscaDados_Genérico(Código, Tabela);

            // Instancia a classe
            Classe_Genérica = InstanciaClasse(Tabela);

            for (int i = 0; i < AFDAL.DtSementinha.Columns.Count; i++)
            {
                // Descobre de qual propriedade da classe o controle atual pertence
                Nome_Campo = AFDAL.DtSementinha.Columns[i].ColumnName;

                // Permite acessar a propriedade em questão
                Propriedade_Genérica = Classe_Genérica.GetType().GetProperty(Nome_Campo);

                // Verifica se o controle em questão, pertence a alguma propriedade da classe
                if (Propriedade_Genérica != null)

                    // Método que insere na propriedade da classe instanciada o valor que está no controle
                    IN_Propriedade_Genérico(Propriedade_Genérica, AFDAL.DtSementinha.Rows[0][i].ToString());                    
            }
            return Classe_Genérica;
        }

        public static void IN_Formulário_Genérico(object Classe_Genérica, string Status)
        {
            string Tipo_Propriedade;
          
            //Esse funciona no Frequentadores: ALDAL.gravaDados_Genérico(Classe_Genérica, Status);

            string Tabela;
            string Parâmetros="";
            string Valores="";

            Tabela = Classe_Genérica.GetType().Name;

            // Retorna todas as propriedades da classe em forma de Array
            PropertyInfo[] Propriedades_Genéricas = Classe_Genérica.GetType().GetProperties();

            for (int i = 0; i < Propriedades_Genéricas.Length; i++)
            {
            
                Parâmetros = Parâmetros + Propriedades_Genéricas[i].Name + ",";

                Valores = Valores + IN_Formulário_Genérico_Valores(Propriedades_Genéricas[i].PropertyType.Name, 
                                                                   Propriedades_Genéricas[i].GetValue(Classe_Genérica, null)) 
                          + ",";             

            }
            Parâmetros = Parâmetros.Substring(0, Parâmetros.Length - 1);
            Valores = Valores.Substring(0, Valores.Length - 1);

            ALDAL.insereDados_Genérico(Tabela, Parâmetros, Valores);
        }

        public static string IN_Formulário_Genérico_Valores(string Tipo_Propriedade, object Valor_Propriedade)
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

        public static object IN_Classe_Genérico(Panel Panel_Genérico)   // Seta todos os valores de um formulário para uma classe    
        {
            // Descobre qual é a classe que será utilizada
            string Nome_Classe = Funções.fncRetornaParteMaiúscula(Panel_Genérico.Controls[0].Name);   
         
            string Tipo_Campo;
            string Nome_Campo;           
            
            // Instancia o objeto classe
            Classe_Genérica = InstanciaClasse(Nome_Classe);           

            // Percorre todos os controles (labels,textbox, buttons, etc) que pertencem ao formulário
            for (int i = 0; i < Panel_Genérico.Controls.Count; i++)
            {
                // Descobre o tipo do controle (label, textbox, button ou qualquer outro)
                Tipo_Campo = Panel_Genérico.Controls[i].Name.Substring(0, 3);

                // A partir do nome do controle(ex: grpFREQUENTADORESsexo), essa função vai retornar "sexo", que é a propriedade                
                Nome_Campo = Funções.fncRetornaNomePropriedade(Nome_Classe, Panel_Genérico.Controls[i].Name);
                
                // Converte o nome "sexo" para "Sexo", ou um nome "data_situação"para "Data_Situação. Isso é para que fique igual ao nome da propriedade da classe
                Nome_Campo = Funções.fncConverteControle_Classe(Nome_Campo);

                // Permite acessar a propriedade em questão
                Propriedade_Genérica = Classe_Genérica.GetType().GetProperty(Nome_Campo);

                // Verifica se o controle em questão, pertence a alguma propriedade da classe
                    if (Propriedade_Genérica != null)
                    {
                        switch (Tipo_Campo)
                        {
                            case "txt":                                
                                IN_Propriedade_Genérico(Propriedade_Genérica, Panel_Genérico.Controls[i].Text); // Método que insere na propriedade da classe instanciada o valor que está no controle
                                break;
                            case "cmb":
                                IN_Propriedade_ComboBox_Genérico(Propriedade_Genérica,Panel_Genérico.Controls[i]);
                                break;
                            case "grp":
                                IN_Propriedade_GroupBox_Genérico(Propriedade_Genérica,Panel_Genérico.Controls[i]);
                                break;
                        }            
                    }               
            }

            return Classe_Genérica;
        }

        private static void IN_Propriedade_GroupBox_Genérico(PropertyInfo Propriedade_Genérica, Control GroupBox_Genérico)
        {
            if (GroupBox_Genérico.Controls[0].Name.Substring(0, 3) == "rdb")
            {
                IN_Propriedade_RadioButton_Genérico(Propriedade_Genérica,GroupBox_Genérico);
            }
        }
        private static void IN_Propriedade_RadioButton_Genérico(PropertyInfo Propriedade_Genérica, Control GroupBox_Genérico)
        {
            RadioButton RadioButton_Genérico;
            string Nome_RadioButton_Genérico;   

            for (int i = 0; i < GroupBox_Genérico.Controls.Count; i++)
            {
                RadioButton_Genérico = (RadioButton)GroupBox_Genérico.Controls[i];

                if (RadioButton_Genérico.Checked == true)
                {
                    Nome_RadioButton_Genérico = Funções.fncConverteControle_Classe(RadioButton_Genérico.Name.Substring(3 + Classe_Genérica.GetType().Name.Length, RadioButton_Genérico.Name.Length - 3 - Classe_Genérica.GetType().Name.Length));

                    // Método que insere na propriedade da classe instanciada o valor que está no controle
                    IN_Propriedade_Genérico(Propriedade_Genérica, Nome_RadioButton_Genérico);

                    // Este comando sai do método
                    break;
                }
            }
        }


        private static void IN_Propriedade_ComboBox_Genérico(PropertyInfo Propriedade_Genérica, Control ComboBox_Genérico)
        {
            // Toda ComboBox por padrão, representa o código do registro da ComboBox nas primeiras posições, até achar o espaço 
            IN_Propriedade_Genérico(Propriedade_Genérica, ComboBox_Genérico.Text.Split(' '));
        }

        public static void IN_Propriedade_Genérico(PropertyInfo Propriedade_Genérica, object Valor_Campo) //Insere valor em uma propriedade
        {
            Type Tipo_Genérico = typeof(Convert);

            // Este comando permite converter um valor de um determinado tipo para o tipo correspondente da propriedade
            var Variável_Genérica = Tipo_Genérico.InvokeMember("To" + Propriedade_Genérica.PropertyType.Name,
                                                  BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null,
                                                  new object[] { Valor_Campo });

            // Finalmente insere o valor na propriedade
            Propriedade_Genérica.SetValue(Classe_Genérica, Variável_Genérica, null);
        }

        public static object InstanciaClasse(string Nome_Classe) 
        {            
            var Classe_Genérica = Assembly.GetExecutingAssembly().GetTypes().First(x => x.Name.ToUpper() == Nome_Classe.ToUpper());
            var Instância = Activator.CreateInstance(Classe_Genérica);
            return Instância;
        }
            
        private static T GetInstanciaDoTipo<T>(string nomeTipo)
        {
            return
                (T)Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.Name == nomeTipo)
                    .Where(t => typeof(T).IsAssignableFrom(t))
                    .Select(Activator.CreateInstance)
                    .First();
        }

    }

    //public static void ListLoadGenérico(Panel Panel_Genérico)
    //{

    //    object DataSet_Genérico="";
    //    string Tipo_Controle;
    //    string Parâmetros;

    //    // Descobre qual é a classe que será utilizada
    //    string Nome_Classe = Funções.fncRetornaParteMaiúscula(Panel_Genérico.Controls[0].Name);

    //    Parâmetros = "'Código,";

    //    for (int i = 0; i < Panel_Genérico.Controls.Count; i++)
    //    {
    //        // Descobre o tipo do controle (label, textbox, button ou qualquer outro)
    //        Tipo_Controle = Panel_Genérico.Controls[i].Name.Substring(0, 3);                

    //        if (Panel_Genérico.Controls[i].GetType() == typeof(Button) && Tipo_Controle == "pan")
    //        {                   
    //            Parâmetros = Parâmetros +                             
    //                         Funções.fncConverteControle_Classe(Panel_Genérico.Controls[i].Name.Substring(3 + Nome_Classe.Length, Panel_Genérico.Controls[i].Name.Length - 3 - Nome_Classe.Length)) +
    //                         "',";
    //        }
    //    }

    //    ALDAL.selecionaDados_Genérico(Parâmetros.Substring(0, Parâmetros.Length - 1), Nome_Classe);            
    //}

     //public static object LêUmRegistroGenérico(string Nome_Classe)
     //   {
     //       // Instancia a classe
     //       Classe_Genérica = RetornaClasse(Nome_Classe);  

     //       Classe_Genérica = AFDAL.LêUmRegistro(Classe_Genérica);
     //       return Classe_Genérica;
     //   }
}

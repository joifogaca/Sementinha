using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Sementinha
{
    class Reflection_Classe
    {
   //     private static object Instância_Genérica;
        private static PropertyInfo Propriedade_Genérica;

        public static object IN_Classe_Genérico(Panel Panel_Genérico)   // Seta todos os valores de um formulário para uma classe    
        {
            // Descobre qual é a classe que será utilizada
            string Nome_Classe = Funções.fncRetornaParteMaiúscula(Panel_Genérico.Controls[0].Name);

            string Tipo_Campo;
            string Nome_Campo;

            // Instancia o objeto classe
            object Instância_Genérica = Reflection.InstanciaClasse(Nome_Classe);

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
                Propriedade_Genérica = Instância_Genérica.GetType().GetProperty(Nome_Campo);

                // Verifica se o controle em questão, pertence a alguma propriedade da classe
                if (Propriedade_Genérica != null)
                {
                    switch (Tipo_Campo)
                    {
                        case "txt":
                            IN_Propriedade_Genérico(Propriedade_Genérica, Panel_Genérico.Controls[i].Text, Instância_Genérica); // Método que insere na propriedade da classe instanciada o valor que está no controle
                            break;
                        case "cmb":
                            IN_Propriedade_ComboBox_Genérico(Propriedade_Genérica, Panel_Genérico.Controls[i], Instância_Genérica);
                            break;
                        case "grp":
                            IN_Propriedade_GroupBox_Genérico(Propriedade_Genérica, Panel_Genérico.Controls[i], Instância_Genérica);
                            break;
                    }
                }
            }

            return Instância_Genérica;
        }
        private static void IN_Propriedade_GroupBox_Genérico(PropertyInfo Propriedade_Genérica, Control GroupBox_Genérico, object Instância_Genérica)
        {
            if (GroupBox_Genérico.Controls[0].Name.Substring(0, 3) == "rdb")
            {
                IN_Propriedade_RadioButton_Genérico(Propriedade_Genérica, GroupBox_Genérico, Instância_Genérica);
            }
        }
        private static void IN_Propriedade_RadioButton_Genérico(PropertyInfo Propriedade_Genérica, Control GroupBox_Genérico, object Instância_Genérica)
        {
            RadioButton RadioButton_Genérico;
            string Nome_RadioButton_Genérico;

            for (int i = 0; i < GroupBox_Genérico.Controls.Count; i++)
            {
                RadioButton_Genérico = (RadioButton)GroupBox_Genérico.Controls[i];

                if (RadioButton_Genérico.Checked == true)
                {
                    Nome_RadioButton_Genérico = Funções.fncConverteControle_Classe(RadioButton_Genérico.Name.Substring(3 + Instância_Genérica.GetType().Name.Length, RadioButton_Genérico.Name.Length - 3 - Instância_Genérica.GetType().Name.Length));

                    // Método que insere na propriedade da classe instanciada o valor que está no controle
                    IN_Propriedade_Genérico(Propriedade_Genérica, Nome_RadioButton_Genérico, Instância_Genérica);

                    // Este comando sai do método
                    break;
                }
            }
        }
        private static void IN_Propriedade_ComboBox_Genérico(PropertyInfo Propriedade_Genérica, Control ComboBox_Genérico, object Instância_Genérica)
        {
            // Toda ComboBox por padrão, representa o código do registro da ComboBox nas primeiras posições, até achar o espaço 
            IN_Propriedade_Genérico(Propriedade_Genérica, ComboBox_Genérico.Text.Split(' '), Instância_Genérica);
        }
        public static void IN_Propriedade_Genérico(PropertyInfo Propriedade_Genérica, object Valor_Campo, object Instância_Genérica) //Insere valor em uma propriedade
        {

            Type Tipo_Genérico = typeof(Convert);
            try
            {
                // Este comando permite converter um valor de um determinado tipo para o tipo correspondente da propriedade
                var Variável_Genérica = Tipo_Genérico.InvokeMember("To" + Propriedade_Genérica.PropertyType.Name,
                                                      BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null,
                                                      new object[] { Valor_Campo });

                // Finalmente insere o valor na propriedade
                Propriedade_Genérica.SetValue(Instância_Genérica, Variável_Genérica, null);
            }
            catch (Exception Err)
            {
                Erro.setErro(Err.Message);
            }
           
        }

    }
}

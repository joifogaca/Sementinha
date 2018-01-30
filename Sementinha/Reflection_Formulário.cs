using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace Sementinha
{
    class Reflection_Formulário
    {
       // private static object Instância_Genérica;
        private static PropertyInfo Propriedade_Genérica;

        public static Panel Attr_Formulário_Genérico(Panel Panel_Genérico, object Instância_Genérica)
        {
            string Tipo_Campo;
            string Nome_Campo;
            string Campo_Identity;

            Campo_Identity = Reflection_BLL.Acha_Campo_Identity(Instância_Genérica.GetType().Name);

            for (int i = 0; i < Panel_Genérico.Controls.Count; i++)
            {
                // Descobre o tipo do controle (label, textbox, button ou qualquer outro)
                Tipo_Campo = Panel_Genérico.Controls[i].Name.Substring(0, 3);

                // A partir do nome do controle(ex: grpFREQUENTADORESsexo), essa função vai retornar "sexo", que é a propriedade
                Nome_Campo = Funções.fncRetornaNomePropriedade(Instância_Genérica.GetType().Name, Panel_Genérico.Controls[i].Name);

                // Padroniza o nome do campo para ficar igual ao nome da propriedade(ex: De "nome_crachá" Para "Nome_Crachá"
                Nome_Campo = Funções.fncConverteControle_Classe(Nome_Campo);

                try
                {
                    // Permite acessar a propriedade em questão
                    Propriedade_Genérica = Instância_Genérica.GetType().GetProperty(Nome_Campo);                  

                    switch (Tipo_Campo)
                    {
                        case "txt":
                            Attr_TextBox_Genérico(Panel_Genérico.Controls[i], Instância_Genérica);
                            break;
                        case "cmb":
                            Attr_ComboBox_Genérico(Panel_Genérico.Controls[i], Instância_Genérica);
                            break;
                        case "grp":
                            Attr_GroupBox_Genérico(Panel_Genérico.Controls[i], Instância_Genérica);
                            break;
                    }
                    // Se o campo for identity no banco de dados, o mesmo é desabilitado.
                    if (Nome_Campo == Campo_Identity) Panel_Genérico.Controls[i].Enabled = false;
                }
                catch (Exception Err)
                {
                    string teste = Err.Message;
                }     
            }
            return Panel_Genérico;
        }
        public static void Attr_TextBox_Genérico(Control Controle_Genérico, object Instância_Genérica)
        {
            Controle_Genérico.Text = Propriedade_Genérica.GetValue(Instância_Genérica, null).ToString();
        }
        public static void Attr_ComboBox_Genérico(Control Controle_Genérico, object Instância_Genérica)
        {
            string Nome_Campo;
            object Item_ComboBox;
            int Contador = 0;
            ComboBox ComboBox_Genérico = (ComboBox)Controle_Genérico;

            // A partir do nome do controle(ex: grpFREQUENTADORESsexo), essa função vai retornar "sexo", que é a propriedade
            Nome_Campo = Funções.fncRetornaNomePropriedade(Instância_Genérica.GetType().Name, Controle_Genérico.Name);

            // Padroniza o nome do campo para ficar igual ao nome da propriedade(ex: De "nome_crachá" Para "Nome_Crachá"
            Nome_Campo = Funções.fncConverteControle_Classe(Nome_Campo);

            // Instancia o objeto classe
            Instância_Genérica = Reflection.InstanciaClasse(Nome_Campo);

            Type Tipo_Genérico = Instância_Genérica.GetType();

            // Retorna uma coleção de objetos para preencher a combobox
            ALDAL.LL_Genérico("*", Nome_Campo);

            // Lê o primeiro registro do Select
            ALDAL.lêUm_Registro(Instância_Genérica);

            while (Erro.getErro() == false)
            {
                // Invoca o método da classe que compõe a string a ser inserida na combobox 
                Item_ComboBox = Tipo_Genérico.InvokeMember("insereRegistro_ComboBox",
                                               BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance, null, Instância_Genérica, new object[] { });

                // Finalmente insere o item na ComboBox
                ComboBox_Genérico.Items.Insert(Contador, Item_ComboBox);

                // Lê o próximo registro do Select
                ALDAL.lêUm_Registro(Instância_Genérica);

                Contador++;
            }
        }
        public static void Attr_GroupBox_Genérico(Control GroupBox_Genérico, object Instância_Genérica)
        {
            if (GroupBox_Genérico.Controls[0].Name.Substring(0, 3) == "rdb")
            {
                Attr_RadioButton_Genérico(GroupBox_Genérico, Instância_Genérica);
            }
        }
        public static void Attr_RadioButton_Genérico(Control GroupBox_Genérico, object Instância_Genérica)
        {
            string Nome_Controle;
            RadioButton RadioButton_Genérico;

            for (int i = 0; i < GroupBox_Genérico.Controls.Count; i++)
            {
                Nome_Controle = Funções.fncRetornaNomePropriedade(Instância_Genérica.GetType().Name, GroupBox_Genérico.Controls[i].Name);
                if (Nome_Controle.ToUpper() == Propriedade_Genérica.GetValue(Instância_Genérica, null).ToString())
                {
                    RadioButton_Genérico = (RadioButton)GroupBox_Genérico.Controls[i];
                    RadioButton_Genérico.Checked = true;
                }
                break;
            }
        }
    }
}

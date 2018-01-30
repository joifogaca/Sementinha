using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Sementinha
{
    class Reflection
    {     
        public static object InstanciaClasse(string Nome_Classe) 
        {            
            var Classe_Genérica = Assembly.GetExecutingAssembly().GetTypes().First(x => x.Name.ToUpper() == Nome_Classe.ToUpper());
            var Instância = Activator.CreateInstance(Classe_Genérica);
            return Instância;
        }
            
        public static T GetInstanciaDoTipo<T>(string nomeTipo)
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

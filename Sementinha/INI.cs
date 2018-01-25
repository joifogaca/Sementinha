using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sementinha
{
    class INI
    {
        // Atributo que permite ler um arquivo de configuração
        [System.Runtime.InteropServices.DllImport("kernel32.DLL")]
        private static extern int GetPrivateProfileStringA(string lpApplicationName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        ////Declarações de Variáveis: depois serão passadas para um .INI
        private static string nome_do_DNS;
        private static string nome_do_servidor;
        private static string tipo_do_BD;
        private static string diretorio_do_BD;

        public static string Diretorio_do_BD
        {
            get { return INI.diretorio_do_BD; }
            set { INI.diretorio_do_BD = value; }
        }

        public static string Tipo_do_BD
        {
            get { return INI.tipo_do_BD; }
            set { INI.tipo_do_BD = value; }
        }

        public static string Nome_do_Servidor
        {
            get { return INI.nome_do_servidor; }
            set { INI.nome_do_servidor = value; }
        }

        public static string Nome_do_DNS
        {
            get { return INI.nome_do_DNS; }
            set { INI.nome_do_DNS = value; }
        }

        public static void fncInicializaINI()
        {
            INI.nome_do_DNS = fncLêINI("Sementinha.INI", "SISTEMA", "Nome_do_DNS");
            INI.nome_do_servidor = fncLêINI("Sementinha.INI", "SISTEMA", "Nome_do_Servidor");
            INI.tipo_do_BD = fncLêINI("Sementinha.INI", "SISTEMA", "Tipo_do_BD");
            INI.diretorio_do_BD = fncLêINI("Sementinha.INI", "SISTEMA", "Path_do_BD");
        }

        public static string fncLêINI(string INI, string Seção, string Item)
        {
            string lpKeyName;
            string lpAppName;
            string lpDefault;
            string lpFileName;
            string Auxiliar = "";
            Auxiliar = Auxiliar.PadRight(128, ' ');

            int Size;
            int Valid;

            StringBuilder lpReturnString = new StringBuilder(Auxiliar);

            lpAppName = Seção;                                      //Nome da Seção
            lpKeyName = Item;                                      //Nome do Parâmetro
            lpDefault = "";                                         //Default de Retorno
            //    lpReturnString = lpReturnString.PadRight(128, ' ');     //Buffer de Retorno
            //     lpReturnString = 
            Size = lpReturnString.Length;                           //Tamanho do Buffer
            lpFileName = INI;                                       //Arquivo INI
            Valid = GetPrivateProfileStringA(lpAppName, lpKeyName, lpDefault, lpReturnString, Size, lpFileName);


            return lpReturnString.ToString().Substring(0, Valid);
        }

    }
}

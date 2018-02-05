using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Sementinha
{
    class Reflection_BLL
    {
        public static string Acha_Campo_Identity(string Tabela)
        {
            // Pesquisa no banco de dados, se há algum campo Identity desta tabela
            AFDAL.ExecuteQuery("EXECUTE Function_RT_Indentity '" + Tabela + "'");

            if (AFDAL.DtSementinha.Rows.Count > 0)
                return AFDAL.DtSementinha.Rows[0][0].ToString();
            else
                return "";
        }

    }
}

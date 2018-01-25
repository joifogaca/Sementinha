using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sementinha
{
    class Erro
    {
        private static Boolean erro;
        private static String mensagem;

        public static void setErro(Boolean _erro)
        {
            erro = _erro;
        }

        public static void setErro(String _mensgem)
        {
            erro = true;
            mensagem = _mensgem;
        }

        public static Boolean getErro() { return erro; }
        public static String getMensagem() { return mensagem; }
    }
}

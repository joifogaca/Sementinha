using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sementinha
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

            // Primeiro lê as variáveis de inicialização(nome do servidor, a pasta de relatórios, etc.)
            //INI.fncInicializaINI();           

        }
    }
}

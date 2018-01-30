using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sementinha
{
    class Formulários
    {
        private long código;
        private string status;
        private string nome_classe;

        public long Código
        {
            get { return código; }
            set { código = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        public string Nome_classe
        {
            get { return nome_classe; }
            set { nome_classe = value; }
        }
          
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitivos.Modelo
{
    class PessoaJuridica  : Account
    {
        public string CNPJ { get; set; }

        public override string getDocumentoFiscal()
        {
            return CNPJ;
        }

    }
}

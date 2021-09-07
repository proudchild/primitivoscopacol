using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitivos.Modelo
{
    class PessoaFisica : Account
    {
        public string CPF { get; set; }
        
        override public string getDocumentoFiscal()
        {
            this.mudaDocumentoFiscal();
            return this.CPF;
        }
    }
}

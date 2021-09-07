using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitivos.Modelo
{
    class Account
    {
        public string DocumentoFiscal { get; set; }

        public virtual string getDocumentoFiscal()
        {
            return null;
        }

        protected string mudaDocumentoFiscal()
        {
            return null;
        }


        public static Account getInstance()
        {
            return new Account();
        }

        public static Account getInstance(string accountId)
        {
            return new Account();
        }

        public static string getInstace(string accountId, bool getFromBase)
        {
            return null;
        }
    }
}

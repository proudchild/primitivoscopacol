using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitivos.Modelo
{
    class Lead
    {
        public string firstName { get; set; }
        public DateTime DataVencimento { get; set; }

        public void setFirstName(String fN)
        {
            if(fN == null || String.IsNullOrEmpty(fN))
            {
                throw new Exception("Arruma esse nome que ele tá vazio");
            }
            this.firstName = fN;
        }

        public string getFirstName()
        {
            return this.firstName;
        }
    }
}

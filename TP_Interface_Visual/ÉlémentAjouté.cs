using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Interface_Visual
{
    class ÉlémentAjouté
    {
        public string NomÉlément { get; set; }
        public string TypeÉlément { get; set; }
        public string DéscriptionÉlément { get; set; }
        public string NomIcône { get; set; }

        public ÉlémentAjouté(string nomElement, string typeElement, string déscriptionElément, string nomIcône)
        {
            NomÉlément = nomElement;
            TypeÉlément = typeElement;
            DéscriptionÉlément = déscriptionElément;
            NomIcône = nomIcône;
        }

        public ÉlémentAjouté()
        {          

        }

        public ÉlémentAjouté(string nomElement)
        {
            NomÉlément = nomElement;
        }


    }
}

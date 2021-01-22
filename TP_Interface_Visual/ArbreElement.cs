using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Interface_Visual
{
    class ArbreElement
    {
        public string NomNoeud { get; set; }
        public List<ArbreElement> Noeuds { get; set; } = new List<ArbreElement>();
        //utilisez ObservableCollection au lieu de List pour notifier l'interface si votre     TreeView change de contenu.
        public List<ÉlémentAjouté> ListElements { get; set; } = new List<ÉlémentAjouté>();

        public ArbreElement()
        { }
        public ArbreElement(string nom)
        {
            NomNoeud = nom;
        }
        public ArbreElement(string nom,  List<ÉlémentAjouté> listElements)
        {
            NomNoeud = nom;
            ListElements = listElements;
        }
    }

}




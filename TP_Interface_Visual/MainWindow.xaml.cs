using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TP_Interface_Visual
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();

//-1--Liste des éléments Installés
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // Liste des éléments généraux (noeud racine)--installés--
            List<ÉlémentAjouté> élémnets_Généraux_Ajoutés = new List<ÉlémentAjouté>() {
            new ÉlémentAjouté("Classe", "Classe Élément visual1 c#", "Classe vide",  "/Icônes/ClassFile_16x.png" ),
            new ÉlémentAjouté("Interface", "Interface Élément visual3 c#","Interface vide","/Icônes/Interfacetp.png") ,
            new ÉlémentAjouté("Appli", "Appli Élément visual c#", "APPli vide","/Icônes/ApplicationClass_16x.png"),
            new ÉlémentAjouté("Contôle utilisateur", "Contôle Élément visual1 c#","Contôle vide","/Icônes/Control_16x.png") ,
            new ÉlémentAjouté("base de Données sur le serveur", "base visual4 c#", "base de Données vide", "/Icônes/Database_16x.png"),
            new ÉlémentAjouté("Contrôle utilisateur(WPF)", "Contrôle visual2 c#","Contrôle vide", "/Icônes/Control_16x.png"),
            new ÉlémentAjouté("Document dynamique (WPD)", "Document visual 5c#", "Document vide", "/Icônes/Document_16x.png"),
            new ÉlémentAjouté("Dictionnaire de ressources(WPF) ", "Dictionnaire Élément visual2 c#","Dictionnaire vide", "/Icônes/ResourceType_16x.png" ),
            new ÉlémentAjouté("Page (WPF) ", "Page Élément visual2 c#","Page vide", "/Icônes/PageFile_16x.png" ) };

            // Liste des éléments WPF (noeud racine) --installés--
            List<ÉlémentAjouté> élémnets_WPF_Ajoutés = new List<ÉlémentAjouté>() { 
            new ÉlémentAjouté("Ecran de démarage (WPF) ", "Ecran Élément visual2 c#","Ecran vide", "/Icônes/Screenshot_16x.png" ), 
            new ÉlémentAjouté("Fenêtre (WPF) ", "Fenêtre Élément visual2 c#","Fenêtre vide", "/Icônes/WindowsForm_16x.png" ),
            new ÉlémentAjouté("Contrôle utilisateur(WPF)", "Contrôle Élément visual2 c#","Contrôle vide", "/Icônes/Control_16x.png"),
            new ÉlémentAjouté("Document dynamique (WPF)", "Document Élément visual 2c#", "Document vide", "/Icônes/Document_16x.png"),
            new ÉlémentAjouté("Dictionnaire de ressources(WPF) ", "Dictionnaire Élément visual2 c#","Dictionnaire vide", "/Icônes/ResourceType_16x.png" ),
            new ÉlémentAjouté("Page (WPF) ", "Page Élément visual2 c#","Page vide", "/Icônes/PageFile_16x.png" )};

            // Liste des éléments généraux (sous noeud )--installés--
            List<ÉlémentAjouté> élémnets_Généraux_Visual_Csharp_Ajoutés = new List<ÉlémentAjouté>() {
              new ÉlémentAjouté("Classe", "Classe Élément visual1 c#", "Classe vide",  "/Icônes/ClassFile_16x.png" ),
              new ÉlémentAjouté("Interface", "InterfaceElement visual1 c#","Interface vide","/Icônes/Interfacetp.png"),           
              new ÉlémentAjouté("Page", "Page Élément visual c#","Page vide","/Icônes/PageFile_16x.png"),  };

            // Liste des éléments WPF (sous noeud )--installés--
            List<ÉlémentAjouté> élémnets_WPF_Visual_Csharp_Ajoutés = new List<ÉlémentAjouté>() {
                new ÉlémentAjouté("Formulaire", "Formulaire Élément visual4 c#","Formulaire vide", "/Icônes/Template_16x.png"),
                new ÉlémentAjouté("base de Données sur le serveur", "Data Élément visual4 c#","base de Données vide", "/Icônes/Database_16x.png") };


 //--2--Liste des éléments en ligne
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // Liste des éléments généraux (noeud racine)-en ligne--

            List<ÉlémentAjouté> enLigne_Éléments_Généreau_Ajoutés = new List<ÉlémentAjouté>() { 
            new ÉlémentAjouté("Common File Template", "File Élément visual5 c#", "Common File Template vide","/Icônes/FileDestination_16x.png"),
            new ÉlémentAjouté("APPli", "APPli Élément visual c#", "APPli vide","/Icônes/ApplicationClass_16x.png"),
            new ÉlémentAjouté("Page", "Page Élément visual c#","Page vide","/Icônes/PageFile_16x.png"),
            new ÉlémentAjouté("Fenêtre", "Fenêtre Élément visual1 c#","Fenêtre vide","/Icônes/WindowsForm_16x.png"),
            new ÉlémentAjouté("Contôle utilisateur", "Contôle Élément visual1 c#","Contôle vide","/Icônes/Control_16x.png")};

            // Liste des éléments WPF (noeud racine) --en ligne--

            List<ÉlémentAjouté> enLigne_Éléments_WPF_Ajoutés = new List<ÉlémentAjouté>() {
                new ÉlémentAjouté("Contrôle utilisateur(WPF)", "Contrôle Élément visual2 c#","Contrôle vide", "/Icônes/Control_16x.png"),
                new ÉlémentAjouté("Document dynamique (WPD)", "Document Élément visual 2c#", "Document vide", "/Icônes/Document_16x.png"),
                new ÉlémentAjouté("Dictionnaire de ressources(WPF) ", "Dictionnaire Élément visual2 c#","Dictionnaire vide", "/Icônes/ResourceType_16x.png" ),
                new ÉlémentAjouté("Page (WPF) ", "Page Élément visual2 c#","Page vide", "/Icônes/PageFile_16x.png" )};


//--3--Additionné tout les listes afin de construire l'arbre des données qui va être envoyée a l'interface
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            ArbreElement Éléments_Installés = new ArbreElement("Installé");
            Éléments_Installés.Noeuds.Add(new ArbreElement("Général", élémnets_Généraux_Ajoutés));
            Éléments_Installés.Noeuds.Add(new ArbreElement("WPF", élémnets_WPF_Ajoutés));

            ArbreElement Éléments_Visual_Csharp = new ArbreElement("Éléments Visual C#");
            Éléments_Visual_Csharp.Noeuds.Add(new ArbreElement("Général", élémnets_Généraux_Visual_Csharp_Ajoutés));
            Éléments_Visual_Csharp.Noeuds.Add(new ArbreElement("WPF", élémnets_WPF_Visual_Csharp_Ajoutés));
            Éléments_Installés.Noeuds.Add(Éléments_Visual_Csharp);

            ArbreElement Éléments_EnLigne = new ArbreElement("En Ligne");
            Éléments_EnLigne.Noeuds.Add(new ArbreElement("Général", enLigne_Éléments_Généreau_Ajoutés));
            Éléments_EnLigne.Noeuds.Add(new ArbreElement("WPF", enLigne_Éléments_WPF_Ajoutés));


//--4-Mettre l'arbre des données (construite précédement dans 3) dans l'arbre virtuelle créer dans XAML( qui a été nommée  : Arbre_Data_liste--): 
    //Note : il s'agit ic d'établir la liaisons de données avec la classe ArbreÉlément dans la HierarchicalDataTemplate de la TreeView            
//OBJECTIF : le but est d'afficher le contenu de cette arbre dans l'interface.
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            Arbre_Data_liste.Items.Add(Éléments_Installés);
            Arbre_Data_liste.Items.Add(Éléments_EnLigne);

        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            DataContext = listBox.SelectedItem;
    }

        public object SelectedItem { get; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

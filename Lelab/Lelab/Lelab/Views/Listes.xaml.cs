using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lelab.Views
{
    public class article
    {
        public string nom { get; set; }
        public string prix { get; set; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listes : ContentPage
    {
        List<article> articles;
        public Listes()
        {
            InitializeComponent();
            articles = new List<article>();
            articles.Add(new article { nom="lait", prix="4€"});
            articles.Add(new article { nom = "chocolat", prix = "12.50€" });
            articles.Add(new article { nom = "pain", prix = "12€" });
            articles.Add(new article { nom = "beurre", prix = "1.2€" });
            //ajouter la listes des articles dans la valeur **listes**  
            listes.ItemsSource = articles;
            //un evenement lorsque on clique sur la liste 
            listes.ItemSelected += (sender, e) =>
            {
                //condition si s"éxecute  quand **listes** a un contenu
                if (listes.SelectedItem != null)
                {
                    article item = listes.SelectedItem as article; // on envoie les donnée de la liste recuprer à l'objet item
                    DisplayAlert(item.nom,item.prix , "OK");//on affiche une alert
                    listes.SelectedItem = null;//on remet la liste a null 
                }
            };
        }
    }
}
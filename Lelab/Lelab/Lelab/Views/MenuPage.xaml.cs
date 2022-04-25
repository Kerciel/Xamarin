using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lelab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }
        //Naviger vers la page CountPage
         void NavCountPage(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new CountPage());
        }
        //Naviguer vers la page de Tabs
        void NavTabs(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Tabs());
        }

        void NavListes(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Listes());
        }
    }
}
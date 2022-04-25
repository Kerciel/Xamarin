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
    public partial class TabVoiture : ContentPage
    {
        public TabVoiture()
        {
            InitializeComponent();
            voitureImage.Opacity = 0;
            voitureImage.TranslationX = 0;
        }

        //evenement a l'apparition 
        protected override void OnAppearing()
        {
            base.OnAppearing();
            voitureImage.Opacity = 0;
           
            voitureImage.FadeTo(1, 3000);
            
            
        }
        //evenement losque sa apparait pas
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            voitureImage.Opacity = 0;
           
        }
    }
}
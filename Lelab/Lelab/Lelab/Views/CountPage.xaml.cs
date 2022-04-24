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
    public partial class CountPage : ContentPage
    {
        int count = 0;
        public CountPage()
        {
            InitializeComponent();
        }

         void CountButtonClick(object sender, EventArgs e)
        {
            count++;
            Countlelab.Text = count.ToString();//on recupere la valeur de Countlelab qu on a defini dans le X:name
            Console.WriteLine("BUTTON MARCHE");
        }
    }
}
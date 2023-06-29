using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Caprasimo-Regular.ttf", Alias = "Caprasimo")]
[assembly: ExportFont("Lexend-Regular.ttf", Alias = "Lexend")]


namespace proyectoFinal_DBP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horas : ContentPage
    {
        public Horas()
        {
            InitializeComponent();
        }

        public void MovePage(object obj, EventArgs args)
        {
            Navigation.PushAsync(new Study());
        }
    }
}
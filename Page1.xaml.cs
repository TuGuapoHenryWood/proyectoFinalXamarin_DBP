using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.SimpleAudioPlayer;
[assembly: ExportFont("Lexend-Regular.ttf", Alias = "Lexend")]
[assembly: ExportFont("Caprasimo-Regular.ttf", Alias = "Caprasimo")]

namespace proyectoFinal_DBP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        public void MovePage(object obj, EventArgs args)
        {
            Navigation.PushAsync(new Study());
        }

        public void MoveTo(object obj, EventArgs args)
        {
            Navigation.PushAsync(new Nuevo());
        }
    }
}





using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyColorPicker.Views;

namespace MyColorPicker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ColorPickerView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

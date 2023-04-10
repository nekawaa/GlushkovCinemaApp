using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GlushkovCinemaApp
{
    public partial class App : Application
    {
        public static int currentUser;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AuthPage())
            {
                BarBackgroundColor = Color.FromHex("#1c1b1b")
            };
           
            
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

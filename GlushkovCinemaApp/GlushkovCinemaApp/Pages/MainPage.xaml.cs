using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GlushkovCinemaApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        public void FilmsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilmsPage());
        }

        public void OrdersBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrdersPage());
        }

        public void TicketsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TicketsPage());
        }
    }
}

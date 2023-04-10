using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GlushkovCinemaApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthPage : ContentPage
    {   
        Users _users;
        public AuthPage()
        {
            
            InitializeComponent();         
        }

        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            _users = new Users();
            _users.username = EntryLogin.Text;
            _users.password = EntryPassword.Text;
            
            if (await UserPost(_users))
            {
                Toast.MakeText(Android.App.Application.Context, "Вход выполнен.", ToastLength.Short).Show();
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                _users = null;
                await DisplayAlert("Ошибка!", "Пользователь не найден.", "Ok");
                return;
            }
        }

        private async Task<bool> UserPost(Users user)
        {
            using (HttpClient client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "http://192.168.1.62:5263/api/Users");
                request.Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                
                var response = await client.SendAsync(request);
                return response.IsSuccessStatusCode;
            }
        }
    }
}
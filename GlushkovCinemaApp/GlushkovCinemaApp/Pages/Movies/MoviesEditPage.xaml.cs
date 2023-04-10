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
    public partial class MoviesEditPage : ContentPage
    {
        Movies _movie;
        public MoviesEditPage(Movies movie)
        {
            InitializeComponent();
            _movie = movie;
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
           Navigation.RemovePage(this);
        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            
            string error = "";
            if (string.IsNullOrWhiteSpace(idEntry.Text))
                error += "Не ввели код фильма!\n";
            if (string.IsNullOrWhiteSpace(nameEntry.Text))
                error += "Не ввели название фильма!\n";
            if (string.IsNullOrWhiteSpace(lenghtEntry.Text))
                error += "Не ввели длину фильма!\n";
            if (string.IsNullOrWhiteSpace(companyEntry.Text))
                error += "Не ввели кинокомпанию!\n";

            if (_movie != null)
            {
                idEntry.Text = _movie.idMovie.ToString();
                nameEntry.Text = _movie.movieName.ToString();
                lenghtEntry.Text = _movie.movieLenght.ToString();
                companyEntry.Text = _movie.filmCompany.ToString();
            }
            
            if (!string.IsNullOrEmpty(error))
            {
                await DisplayAlert("Ошибка!", "Произошла ошибка! Причины могут быть в следующем\n\n" + error, "Ок");
                return;
            }
            if (_movie != null)
            {
                _movie.idMovie = Convert.ToInt32(idEntry.Text);
                _movie.movieName = Convert.ToString(nameEntry.Text);
                _movie.movieLenght = Convert.ToString(lenghtEntry.Text);
                _movie.filmCompany = Convert.ToString(companyEntry.Text);        
                if (await PutService(_movie.idMovie.ToString(), _movie))
                    Toast.MakeText(Android.App.Application.Context, "Изменения внесены успешно!", ToastLength.Short).Show();
                else
                {
                    await DisplayAlert("Ошибка!", "Проверьте соединение", "Ок");
                    return;
                }

            }
            else
            {
                _movie = new Movies()
                {
                    idMovie = Convert.ToInt32(idEntry.Text),
                    movieName = nameEntry.Text,
                    movieLenght = lenghtEntry.Text,
                    filmCompany = companyEntry.Text,

                };
                if (await PostService(_movie)) Toast.MakeText(Android.App.Application.Context, "Добавление успешно!", ToastLength.Short).Show();
                else
                {
                    _movie = null;
                    await DisplayAlert("error", "", "ok");
                    return;
                }
            }

            Navigation.RemovePage(this);
        }
        private async Task<bool> PostService(Movies movies)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "http://192.168.1.62:5263/api/Movies/");
                string context = JsonConvert.SerializeObject(movies);
                request.Content = new StringContent(context, Encoding.UTF8, "application/json");
                var response = await httpclient.SendAsync(request);
                return response.IsSuccessStatusCode;
            }
        }
        private async Task<bool> PutService(string a, Movies movies)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Put, "http://192.168.1.62:5263/api/Movies/" + a);
                request.Content = new StringContent(JsonConvert.SerializeObject(movies), Encoding.UTF8, "application/json");
                var response = await httpclient.SendAsync(request);
                return response.IsSuccessStatusCode;
            }
        }
    }
}
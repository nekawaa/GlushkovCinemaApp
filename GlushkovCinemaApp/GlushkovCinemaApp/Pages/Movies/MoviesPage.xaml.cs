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
    public partial class FilmsPage : ContentPage
    {
        public FilmsPage()
        {
            InitializeComponent();
        }

        public async Task<List<Movies>> GetData()
        {
            using (HttpClient client = new HttpClient())
            {
                var stringData = await client.GetStringAsync("http://192.168.1.62:5263/api/Movies/");
                if (stringData == null)
                {
                    await DisplayAlert("error!", "no respond", "ok");
                }
                return JsonConvert.DeserializeObject<List<Movies>>(stringData);
            }
        }
        private async Task<bool> Delete(int a)
        {
            using (HttpClient client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Delete, "http://192.168.1.62:5263/api/Movies/" + a);
                var response = await client.SendAsync(request);
                return response.IsSuccessStatusCode;
            }
        }
        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            LVData.ItemsSource = await GetData();
        }

        private async void BtnEd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MoviesEditPage((sender as Button).BindingContext as Movies));
            LVData.ItemsSource = await GetData();
        }

        private async void BtnDel_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Удалить?", "", "Да", "Нет"))
            {
                if (await Delete(((sender as Button).BindingContext as Movies).idMovie)) Android.Widget.Toast.MakeText(Android.App.Application.Context, "Удаление успешно!", Android.Widget.ToastLength.Short).Show();
                else
                    await DisplayAlert("error", "check connection", "ok");
                LVData.ItemsSource = await GetData();
            }
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MoviesEditPage(null));
        }
    }
}
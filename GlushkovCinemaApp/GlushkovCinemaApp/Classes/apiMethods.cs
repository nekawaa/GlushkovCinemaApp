using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using GlushkovCinemaApp.Classes;
using System.Threading.Tasks;

namespace GlushkovCinemaApp.Classes
{
    class apiMethods
    {
        //Авторизация сюда засуну, а то че класс пустой
        public static async Task<bool> LoginAsync(string UserLogin, string UserPassword)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var LoginClient = new Users() { username = UserLogin, password = UserPassword };
                    HttpContent load = new StringContent(JsonConvert.SerializeObject(LoginClient), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://192.168.1.62:5263/api/Users/", load);
                    if (response.IsSuccessStatusCode)
                    {
                        App.currentUser = Convert.ToInt16(await response.Content.ReadAsStringAsync());
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

        }
    }

    public static class MoviesMeth
    {
        public static async Task<bool> PostMoviesAsync(Movies movie)
        {

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpContent load = new StringContent(JsonConvert.SerializeObject(movie), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://192.168.1.62:5263/api/Movies/", load);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


            }
            catch (Exception)
            {

                return false;
            }


        }
        public static async Task<bool> PutMoiveAsync(Movies movie)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpContent load = new StringContent(JsonConvert.SerializeObject(movie), Encoding.UTF8, "application/json");
                    var response = await client.PutAsync("http://192.168.1.62:5263/api/Movies/", load);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
    }

    public static class OrdersMeth
    {
        public static async Task<bool> PostOrderAsync(Orders order)
        {

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpContent load = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://192.168.1.62:5263/api/Orders/", load);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


            }
            catch (Exception)
            {

                return false;
            }


        }
        public static async Task<bool> PutOrderAsync(Orders order)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpContent load = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");
                    var response = await client.PutAsync("http://192.168.1.62:5263/api/Orders/", load);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    public static class EmployeesMeth
    {
        public static async Task<bool> PostEmployeeAsync(Employees employee)
        {

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpContent load = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://192.168.1.62:5263/api/Employees/", load);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


            }
            catch (Exception)
            {

                return false;
            }


        }
        public static async Task<bool> PutEmployeeAsync(Employees employee)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpContent load = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
                    var response = await client.PutAsync("http://192.168.1.62:5263/api/Employees/", load);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
    }

    public static class BuffetsMeth
    {
        public static async Task<bool> PostBuffetAsync(Buffets buffet)
        {

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpContent load = new StringContent(JsonConvert.SerializeObject(buffet), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://192.168.1.62:5263/api/Buffets/", load);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


            }
            catch (Exception)
            {

                return false;
            }


        }
        public static async Task<bool> PutBuffetAsync(Buffets buffet)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpContent load = new StringContent(JsonConvert.SerializeObject(buffet), Encoding.UTF8, "application/json");
                    var response = await client.PutAsync("http://192.168.1.62:5263/api/Buffets/", load);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
    public static class TicketsMeth
    {
        public static async Task<bool> PostTicketAsync(Tickets ticket)
        {

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpContent load = new StringContent(JsonConvert.SerializeObject(ticket), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://192.168.1.62:5263/api/Tickets/", load);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


            }
            catch (Exception)
            {

                return false;
            }


        }
        public static async Task<bool> PutTicketAsync(Tickets ticket)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpContent load = new StringContent(JsonConvert.SerializeObject(ticket), Encoding.UTF8, "application/json");
                    var response = await client.PutAsync("http://192.168.1.62:5263/api/Tickets/", load);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

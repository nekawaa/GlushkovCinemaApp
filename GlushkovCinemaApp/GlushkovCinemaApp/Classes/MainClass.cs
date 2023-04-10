using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GlushkovCinemaApp
{
   
    public class Products
    {
        public int idProduct { get; set; }
        public string productName { get; set; }
        public int price { get; set; }
    }
    public class Employees
    {
        public int idEmployee { get; set; }
        public string employeeName { get; set; }
        public string employeePost { get; set; }
    }

    public class Movies
    {
        public int idMovie { get; set; }
        public string movieName { get; set; }
        public string movieLenght { get; set; }
        public string filmCompany { get; set; }
    }
    public class Users
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }


    public class Orders
    {
        public int idOrder { get; set; }
        public int idTicket { get; set; }
        public int idProduct { get; set; }
        public int price { get; set; }
        public int idEmployee { get; set; }
        public Idemployeenavigation idEmployeeNavigation { get; set; }
        public Idproductnavigation idProductNavigation { get; set; }
        public Idticketnavigation idTicketNavigation { get; set; }
    }

    public class Idemployeenavigation
    {
        public int idEmployee { get; set; }
        public string employeeName { get; set; }
        public string employeePost { get; set; }
    }

    public class Idproductnavigation
    {
        public int idProduct { get; set; }
        public string productName { get; set; }
        public int price { get; set; }
    }

    public class Idticketnavigation
    {
        public int idTicket { get; set; }
        public int idMovie { get; set; }
        public string time { get; set; }
        public int price { get; set; }
        public Idmovienavigation idMovieNavigation { get; set; }
    }

    public class Idmovienavigation
    {
        public int idMovie { get; set; }
        public string movieName { get; set; }
        public string movieLenght { get; set; }
        public string filmCompany { get; set; }
    }

    public class Tickets
    {
        public int idTicket { get; set; }
        public int idMovie { get; set; }
        public string time { get; set; }
        public int price { get; set; }
        public Idmovienavigation idMovieNavigation { get; set; }
    }


  
    public class Buffets
    {
        public int idProduct { get; set; }
        public string productName { get; set; }
        public int price { get; set; }
    }

}

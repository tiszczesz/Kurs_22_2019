using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DAL.Models;

namespace ConsoleApp
{
    class Program
    {
        public static string GetConnection()
        {
            var conn = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            return conn;
        }
        static void Main(string[] args)
        {
            var connString = GetConnection();
            var repo = new SqlRepository(connString);
            List<Pracownik> lista = repo.Pracownicy();
            foreach (var pracownik in lista)
            {
                Console.WriteLine(pracownik.Imie+" "+pracownik.Nazwisko
                                  +" Pensja: "+pracownik.Pensja);
            }
            Console.ReadKey();
        }
    }
}

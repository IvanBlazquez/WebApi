using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RestSharp;
using InterfazdeBeers.Models;

namespace InterfazdeBeers
{
    public class BeersModel : PageModel
    {
        public List<Beer> Beers { get; set; }
        public string Marca { get; set; }
        public string Origen { get; set; }
        public string Tipo { get; set; }
        public double Grados { get; set; }
        public string Imagen { get; set; }
        private static Random random = new Random();
        private object GenerateRandomId(int v)
        {
            string strarray = "abcdefghijklmnopqrstuvwxyz123456789";
            return new string(Enumerable.Repeat(strarray, v).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        [HttpGet]
        public void OnGet()
        {
            var client = new RestClient("https://localhost:44371/api/Beers");
            var request = new RestRequest(Method.GET);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            Beers = JsonConvert.DeserializeObject<List<Beer>>(response.Content);
            //bug->no acepta valor nulo, no cogue los datos
            Beers.Where(b=>b.Marca == "Heineken").ToList();
        }
        [HttpPost]
        public void OnPost()
        {
            var client = new RestClient("https://localhost:44371/api/Beers");
            var request = new RestRequest(Method.POST);

            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");

            request.AddParameter("_id", GenerateRandomId(24));
            request.AddParameter("Marca", Marca);
            request.AddParameter("Origen", Origen);
            request.AddParameter("Tipo", Tipo);
            request.AddParameter("Grados", Grados);
            request.AddParameter("Imagen", Imagen);

            IRestResponse response = client.Execute(request);
            OnGet();
        }
       
    }
}
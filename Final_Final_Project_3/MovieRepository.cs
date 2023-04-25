using AngleSharp.Io;
using Azure.Core;
using EO.WebBrowser;
using Final_Final_Project_3.Models;
using Ninject.Activation;
using Org.BouncyCastle.Asn1.Ocsp;
using RestSharp;

namespace Final_Final_Project_3
{
    public class MovieRepository : IMovieRepository
    {
        private readonly string _conn;

        public MovieRepository(string conn)
        {
            _conn = conn;
        }

        public Movie GetApiResponse()
        {
            var movie = new Movie();

            var client = new HttpClient();

            var apiCall = $"https://imdb-top-100-movies.p.rapidapi.com/%22";
            var request = new RestRequest();
             // Not completed yet, so if it doesnt make sense dont yell
            request.AddHeader("content-type", "application/octet-stream");
            request.AddHeader("X-RapidAPI-Key", $"{_conn}");
            request.AddHeader("X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com");
            movie.APIResponse = client.GetStringAsync(apiCall);

            var response = client.Execute(request);
                
            // Adding parse methods here







            //returns everything we parsed
            return movie;
        }
    }
}

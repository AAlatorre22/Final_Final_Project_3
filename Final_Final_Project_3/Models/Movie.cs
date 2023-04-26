namespace Final_Final_Project_3.Models
{
    public class Movie
    {
        public Movie()
        {


        }

        //things we want go here
        //public string genre { get; set; }
        //public string title { get; set; }
        //public string rating { get; set; }
        //public int year { get; set; }
        //public int rank { get; set; }
        //public string APIResponse { get; set; }


        // Movie myDeserializedClass = JsonConvert.DeserializeObject<List<Movie>>(myJsonResponse);
        public string Rank { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Rating { get; set; }
        public string Id { get; set; }
        public string Year { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Trailer { get; set; }
        public string Genre { get; set; }
        public List<string> Director { get; set; }
        public List<string> Writers { get; set; }
        public string Imdbid { get; set; }


        public string APIResponse { get; set; }

        //public List<Movie> MoviesList { get; set; } = new List<Movie>();
    }
}

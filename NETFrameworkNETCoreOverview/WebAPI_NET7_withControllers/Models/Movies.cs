namespace WebAPI_NET7_withControllers.Models
{
    public class Movies
    {
        public int Id { get; set; } 

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }  

        public GenreType Type { get; set; }

        public int IMDB_RAting { get; set; }
    }

    public enum GenreType { Action, Comedy, Drama, Romance, Horror, ScienceFiction, Animation, Thriller, Biography, Docu }
}

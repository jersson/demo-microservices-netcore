namespace demo_microservices_netcore.Core.Models
{
    public class BookInformation
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }

        public BookInformation(string title, string author, string year){
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }
    }
}
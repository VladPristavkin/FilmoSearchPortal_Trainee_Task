namespace FilmoSearchPortal.Domain.Models
{
    public class Review
    {
        public required int Id { get; set; }
        public int FilmId { get; set; }
        public Film? Film { get; set; }

        //TODO: Add user part

        public required int Stars { get; set; }
        public required string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}

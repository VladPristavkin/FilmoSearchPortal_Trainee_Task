using FilmoSearchPortal.Application.DTO.Film;

namespace FilmoSearchPortal.Application.DTO.Review
{
    public record ReviewDto
    {
        public required int Id { get; set; }
        public int FilmId { get; set; }
        public FilmDto? Film { get; set; }

        //TODO: Add user part

        public required int Stars { get; set; }
        public required string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}

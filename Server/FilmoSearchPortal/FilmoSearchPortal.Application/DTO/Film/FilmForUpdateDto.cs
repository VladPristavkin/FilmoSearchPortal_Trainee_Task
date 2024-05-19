namespace FilmoSearchPortal.Application.DTO.Film
{
    public record FilmForUpdateDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? ReleaseYear { get; set; }
        public int? Duration { get; set; }
        public float? Rating { get; set; }

        public int DirectorId { get; set; }

        public IEnumerable<int>? ActorIds { get; set; }
        public IEnumerable<int>? GenresIds { get; set; }
    }
}

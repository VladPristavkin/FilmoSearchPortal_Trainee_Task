namespace FilmoSearchPortal.Application.DTO.Review
{
    public record ReviewForCreatingDto
    {
        public int? FilmId { get; set; }

        //TODO: Add user part

        public required string Comment { get; set; }
        public required int Stars { get; set; }
    }
}

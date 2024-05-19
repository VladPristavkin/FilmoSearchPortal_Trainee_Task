using AutoMapper;
using FilmoSearchPortal.Application.DTO.Actor;
using FilmoSearchPortal.Application.DTO.Director;
using FilmoSearchPortal.Application.DTO.Film;
using FilmoSearchPortal.Application.DTO.Genre;
using FilmoSearchPortal.Application.DTO.Review;
using FilmoSearchPortal.Domain.Models;

namespace FilmoSearchPortal.Application.Common.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Actor, ActorDto>().ReverseMap();
            CreateMap<ActorForCreatingDto, ActorDto>().ReverseMap();
            CreateMap<ActorForCreatingDto, Actor>().ReverseMap();
            CreateMap<ActorForUpdateDto, Actor>().ReverseMap();

            CreateMap<Director, DirectorDto>().ReverseMap();
            CreateMap<DirectorForCreatingDto, DirectorDto>().ReverseMap();
            CreateMap<DirectorForCreatingDto, DirectorDto>().ReverseMap();
            CreateMap<DirectorForUpdateDto, Director>().ReverseMap();

            CreateMap<Film, FilmDto>().ReverseMap();
            CreateMap<FilmForCreatingDto, FilmDto>().ReverseMap();
            CreateMap<FilmForCreatingDto, Film>().ReverseMap();
            CreateMap<FilmForUpdateDto, Film>().ReverseMap();

            CreateMap<Genre, GenreDto>().ReverseMap();
            CreateMap<GenreForCreatingDto, GenreDto>().ReverseMap();
            CreateMap<GenreForCreatingDto, Genre>().ReverseMap();
            CreateMap<GenreForUpdateDto, Genre>().ReverseMap();

            CreateMap<Review, ReviewDto>().ReverseMap();
            CreateMap<ReviewForCreatingDto, ReviewDto>().ReverseMap();
            CreateMap<ReviewForCreatingDto, Review>().ReverseMap();
            CreateMap<ReviewForUpdateDto, Review>().ReverseMap();
        }
    }
}

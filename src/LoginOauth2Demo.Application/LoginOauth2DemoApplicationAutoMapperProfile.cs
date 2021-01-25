using AutoMapper;
using LoginOauth2Demo.Entities;
using LoginOauth2Demo.Entities.Dtos;

namespace LoginOauth2Demo
{
    public class LoginOauth2DemoApplicationAutoMapperProfile : Profile
    {
        public LoginOauth2DemoApplicationAutoMapperProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>(MemberList.Source);
        }
    }
}
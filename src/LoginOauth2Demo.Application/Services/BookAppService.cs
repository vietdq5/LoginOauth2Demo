using LoginOauth2Demo.Entities.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace LoginOauth2Demo.Entities
{
    public class BookAppService : CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto, CreateUpdateBookDto>,
        IBookAppService
    {
        private readonly IBookRepository _repository;

        public BookAppService(IBookRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
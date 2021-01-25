using LoginOauth2Demo.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace LoginOauth2Demo.Entities
{

    [Route("/api/loginOauth2Demo/book")]
    public class BookController : LoginOauth2DemoController, IBookAppService
    {
        private readonly IBookAppService _service;

        public BookController(IBookAppService service)
        {
            _service = service;
        }

        [HttpPost]
        public virtual Task<BookDto> CreateAsync(CreateUpdateBookDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public virtual Task<BookDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
        {
            return _service.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public virtual Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }

        [HttpGet]
        [Route("{id}")]
        public virtual Task<BookDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public virtual Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return _service.GetListAsync(input);
        }
    }
}
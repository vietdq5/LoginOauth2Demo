using System;
using Volo.Abp.Application.Dtos;

namespace LoginOauth2Demo.Entities.Dtos
{
    [Serializable]
    public class BookDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}
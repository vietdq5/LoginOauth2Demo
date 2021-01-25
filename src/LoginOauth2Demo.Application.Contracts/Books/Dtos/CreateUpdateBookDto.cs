using System;

namespace LoginOauth2Demo.Entities.Dtos
{
    [Serializable]
    public class CreateUpdateBookDto
    {
        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}
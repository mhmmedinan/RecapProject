using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Entities.Concrete
{
    public class Image : IEntity
    {
        public IFormFile Files { get; set; }
    }
}

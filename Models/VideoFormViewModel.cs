using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netflex.Models
{
    public class VideoFormViewModel
    {
        public Movie Movie { get; set; }
        public IFormFile File{ get; set; }
    }
}

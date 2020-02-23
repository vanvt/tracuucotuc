using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication34.Models
{
    public class ImportVM
    {
        public int Year { get; set; }
        public IFormFile Myfile { set; get; }
    }
}

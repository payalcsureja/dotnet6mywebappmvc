using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services.ProductAPI.Models.Dto
{
    public class ProductDto
    {
        
        public int ProductId { get; set; }
        public string Name { get; set; }
        public Double Price { get; set; }
        public String Description { get; set; }
        public String CategoryName { get; set; }
        public String ImageUrl { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Services.ProductAPI.Models;
using App.Services.ProductAPI.Models.Dto;
using AutoMapper;

namespace App.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps(){
            
            var MappingConfig = new MapperConfiguration(config=>{
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return MappingConfig;

        }
    }
}
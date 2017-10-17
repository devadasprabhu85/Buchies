using AutoMapper;
using Buchies_Service;
using Buchies_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Buchies_Web
{
    public class AutoMapperConfig
    {
        public static void configure()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserViewModel>().ReverseMap();
                cfg.CreateMap<Product, ProductViewModel>().ReverseMap();

            });
        }
    }
}
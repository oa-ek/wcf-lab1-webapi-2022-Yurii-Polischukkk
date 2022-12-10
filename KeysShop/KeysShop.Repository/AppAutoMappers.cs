using AutoMapper;
using KeysShop.Core;
using Laboratorna.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeysShop.Repository
{
    public class AppAutoMapper : Profile
    {
        public AppAutoMapper()
        {
            CreateMap<BrandCreateDto, Brand>();
            CreateMap<Brand, BrandCreateDto>();
        }
    }

}

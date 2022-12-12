using KeysShop.Core;
using KeysShop.Repository;
using KeysShop.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace KeyShop.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly BrandRepository _brandRepository;
        public BrandController(BrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

     
        [HttpGet]
        public List<BrandCreateDto> GetBrands()
        {
            var brands = _brandRepository.GetBrands();
            return brands;
        }


      
        [HttpGet("{id}")]
        public Brand GetBrand(int id)
        {
            return _brandRepository.GetBrand(id);
        }

      
        [HttpPost]
        public async Task<Brand> Create(BrandCreateDto brandDto)
        {
            var createdBrand = await _brandRepository.AddBrandByDtoAsync(brandDto);
            return createdBrand;
        }

        
        [HttpPut]
        public async Task Edit(BrandCreateDto brand)
        {
            await _brandRepository.UpdateBrandAsync(brand);
        }

        
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _brandRepository.DeleteBrandAsync(id);
        }
    }
}
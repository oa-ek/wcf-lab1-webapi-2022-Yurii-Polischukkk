using KeysShop.Core;
using KeysShop.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.AspNetCore.Hosting;
using Swashbuckle.AspNetCore.Annotations;
using KeysShop.Shared.Dtos;

namespace KeysShop.UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KeyController : ControllerBase
    {
        private readonly KeysRepository keysRepository;
        private readonly BrandRepository brandsRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public KeyController(KeysRepository keysRepository, BrandRepository brandRepository, IWebHostEnvironment webHostEnvironment)
        {
            this.keysRepository = keysRepository;
            brandsRepository = brandRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        
        [HttpGet("getkeys/")]
        public List<Key> GetKeys()
        {
            var keys = keysRepository.GetKeys();
            return keys;
        }

        [HttpGet("getkey/{id}")]
        public Key GetBrand(int id)
        {
            return keysRepository.GetKey(id);
        }

      
        [HttpPost("createkey/")]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public async Task CreateKey(KeyCreateDto keyCreateDto, string brands)
        {
            var brand = brandsRepository.GetBrandByName(brands);
            if (brand == null)
            {
                brand = new Brand() { Name = brands };
                brand = await brandsRepository.AddBrandAsync(brand);
            }

            var key = await keysRepository.AddKeyAsync(new Key()
            {
                Name = keyCreateDto.Name,
                Description = keyCreateDto.Description,
                Price = keyCreateDto.Price,
                Sale = keyCreateDto.Sale,
                Frequency = keyCreateDto.Frequency,
                Count = keyCreateDto.Count,
                ImgPath = keyCreateDto.ImgPath,
                IsOriginal = keyCreateDto.IsOriginal,
                IsKeyless = keyCreateDto.IsKeyless,
                Brand = brand
            });
        }

       

        [HttpPost("editkey/")]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public async Task Edit(KeyCreateDto model, string brands)
        {
            await keysRepository.UpdateAsync(model, brands);
        }

       
        [HttpPost("confirmdelete/{id}")]
        public async Task ConfirmDelete(int id)
        {
            await keysRepository.DeleteKeyAsync(id);
        }
    }
}
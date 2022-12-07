﻿using KeysShop.Core;
using KeysShop.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace KeyShop.UI.Controllers
{
    public class BrandController : Controller
    {
        private readonly BrandRepository _brandRepository;
        public BrandController(BrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public IActionResult Index()
        {
            var brands = _brandRepository.GetBrands();
            return View(brands);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Brand brand)
        {
            if (ModelState.IsValid)
            {
                var createdBrand = await _brandRepository.AddBrandAsync(brand);
                return RedirectToAction("Edit", "Brand", new { id = createdBrand.Id });
            }
            return View(brand);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_brandRepository.GetBrand(id));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Brand brand)
        {
            if (ModelState.IsValid)
            {
                await _brandRepository.UpdateBrandAsync(brand);
                return RedirectToAction("Index");
            }
            return View(brand);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_brandRepository.GetBrand(id));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Delete(Brand brand)
        {
            await _brandRepository.DeleteBrandAsync(brand.Id);
            return RedirectToAction("Index");
        }
    }
}

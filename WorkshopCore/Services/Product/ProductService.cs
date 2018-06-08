using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopCore.Models;

namespace WorkshopCore.Services
{
    public class ProductService : IProductService
    {
        private WorkshopContext _context;
        private ModelStateDictionary _modelState;
        private IFileService _fileService;

        public ModelStateDictionary ModelState
        {
            get
            {
                return _modelState;
            }
        }

        public void AddModelState(ModelStateDictionary modelState)
        {
            _modelState = modelState;
        }

        public ProductService(WorkshopContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }

        public async Task<Product> Create(Product product, IFormFile file)
        {
            if (!Validate(product))
            {
                throw new Exception("Failed to create the prodcut");
            }

            product.ProductImage.Add(new ProductImage
            {
                FilePath = _fileService.CreateFile(file)
            });

            _context.Add(product);

            await _context.SaveChangesAsync();

            return product;
        }

        public bool Validate(Product product)
        {
            return _modelState.IsValid;
        }
    }
}

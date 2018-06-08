using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopCore.Models;

namespace WorkshopCore.Services
{
    public interface IProductService
    {
        Task<Product> Create(Product product, IFormFile file);

        void AddModelState(ModelStateDictionary modelState);
        ModelStateDictionary ModelState { get; }
    }
}

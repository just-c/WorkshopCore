using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WorkshopCore.Models;
using Microsoft.AspNetCore.Http;

namespace WorkshopCore.Services
{
    public interface IRequestService
    {
        Task<Request> Create(Request request, IFormFile file);

        void AddModelState(ModelStateDictionary modelState);
        ModelStateDictionary ModelState { get; }
    }
}

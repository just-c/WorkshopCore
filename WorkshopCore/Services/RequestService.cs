using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WorkshopCore.Models;

namespace WorkshopCore.Services
{
    public class RequestService : IRequestService
    {
        private WorkshopContext _context;
        private ModelStateDictionary _modelState;

        public ModelStateDictionary ModelState
        {
            get
            {
                return _modelState;
            }
        }

        public RequestService(WorkshopContext context)
        {
            _context = context;
        }

        public void AddModelState(ModelStateDictionary modelState)
        {
            _modelState = modelState;
        }

        /// <summary>
        /// Creates a new request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Request> Create(Request request)
        {
            _context.Add(request);

            await _context.SaveChangesAsync();

            return request;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private bool Validate(Request request)
        {
            //TODO Implement validate method
            return _modelState.IsValid;
        }
    }
}

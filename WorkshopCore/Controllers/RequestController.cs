using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkshopCore.Models;
using WorkshopCore.Services;
using Microsoft.AspNetCore.Http;

namespace WorkshopCore.Controllers
{
    public class RequestController : Controller
    {
        private readonly WorkshopContext _context;
        private IRequestService _service;

        public RequestController(WorkshopContext context, IRequestService service)
        {
            _context = context;
            _service = service;

            _service.AddModelState(this.ModelState);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, FirstName, LastName, Email, Comment")] Request request, IFormFile image)
        {
            try
            {
                await _service.Create(request, image);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                ModelState.Merge(_service.ModelState);
                return View("Index", request);
            }
        }
    }
}
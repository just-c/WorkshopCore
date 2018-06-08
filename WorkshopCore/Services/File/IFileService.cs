using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopCore.Services
{
    public interface IFileService
    {
        string CreateFile(IFormFile file);
    }
}

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace WorkshopCore.Services
{
    public class FileService : IFileService
    {
        private IHostingEnvironment _environment;

        public FileService(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public string CreateFile(IFormFile file)
        {
            string fileName = Path.GetFileName(file.FileName);
            string filePath = Path.Combine(_environment.WebRootPath, "uploads/");
            string path = Path.Combine(filePath, fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return fileName;
        }
    }
}

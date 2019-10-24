using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace CESP.Core.Managers.File
{
    public class FileManager : IFileManager
    {
        public FileManager(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task SaveImage(IFormFile file, string destinationFolder)
        {
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, destinationFolder);
            if (file.Length > 0)
            {
                var filePath = Path.Combine(uploads, file.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
        }

        public Task SaveImages(IFormFile[] files, string destinationFolder)
        {
            return Task.WhenAll(files.Select(file => SaveImage(file, destinationFolder)));
        }

        private readonly IHostingEnvironment _hostingEnvironment;
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using WebUploadFileS3.Interfaces;

namespace WebUploadFileS3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepositoryS3 _repositoryS3;
        private readonly ILogger<IndexModel> _logger;
        [BindProperty] public IFormFile File { get; set; }
        public string Message { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IRepositoryS3 repositoryS3)
        {
            _logger = logger;
            _repositoryS3 = repositoryS3;
        }
        
        public void OnGet()
        {

        }        
        public async Task<IActionResult> OnPostAsync()
        {
            if (File != null && File.Length > 0)
            {
                await _repositoryS3.UploadFileAsync(File);
            }

            return Page();
        }
    }

}
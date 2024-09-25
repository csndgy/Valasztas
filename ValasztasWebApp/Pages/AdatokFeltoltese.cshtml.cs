using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ValasztasWebApp.Models;

namespace ValasztasWebApp.Pages
{
    public class AdatokFeltolteseModel : PageModel
    {


        private readonly IWebHostEnvironment _env;
        private readonly ValasztasDbContext _context;

        public AdatokFeltolteseModel
            (IWebHostEnvironment env,
            ValasztasDbContext context)
        { _context = context;
            _env = env;
        }



        [BindProperty]
        public IFormFile UploadFile { get; set; }
        
        
        
        
        
        
        
        
        
        public void OnGet()
        {
        }




        public async Task<IActionResult> OnPostAsync()
        {
            var UploadFilePath = Path.Combine(_env.ContentRootPath
                , "Uploads", UploadFile.FileName);

            using (var stream = new FileStream(UploadFilePath,FileMode.Create
                ))
            {
                await UploadFile.CopyToAsync(stream);
            }

            StreamReader sr = new StreamReader(UploadFilePath);
            sr.Close();



                return Page();
        }
    }
}

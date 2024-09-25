using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ValasztasWebApp.Pages
{
    public class AdatokFeltolteseModel : PageModel
    {


        private readonly IWebHostEnvironment _env;





        [BindProperty]
        public IFormFile UploadFile { get; set; }
        
        
        
        
        
        
        
        
        
        public void OnGet()
        {
        }
    }
}

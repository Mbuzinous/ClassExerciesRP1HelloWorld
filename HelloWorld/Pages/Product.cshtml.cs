using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorld.Pages
{
    public class ProductModel : PageModel
    {
        public string Name { get; private set; }
        public void OnGet()
        {
            Name = "Weber Grill";
        }
    }
}

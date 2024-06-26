// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProtectedWeb.Attributes.Permissions;

namespace ProtectedWeb.Pages.Manufacturer
{
    [Admin]
    [ValidateAntiForgeryToken]
    public class AddModel : PageModel
    {
        private readonly SneakersContext _context;

        public AddModel(SneakersContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string Name { get; set; }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            Models.Manufacturer manufacturer = new() {
                Name = Name 
            };
            _context.Manufacturers.Add(manufacturer);
            _context.SaveChanges();
            return RedirectToPage("Catalog");
        }
    }
}

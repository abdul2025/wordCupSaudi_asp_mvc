using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using worldcup.Data;
using worldcup.Models;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace worldcup.Controllers
{
    public class DashboardController: Controller
    {

    private readonly ApplicationDbContext _context;
    private readonly IWebHostEnvironment _webHostEnvironment;

    // Combined constructor to inject both dependencies
    public DashboardController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
    {
        _context = context;
        _webHostEnvironment = webHostEnvironment;
    }

    public IActionResult Index()
    {
        return View();
    }


    public async Task<IActionResult> CreateCategorie(string Name, string Description, string Icon, IFormFile Image)
    {
        if (Image != null && Image.Length > 0)
        {
            Console.WriteLine(Image.FileName);
            // Generate a unique file name to avoid overwriting
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(Image.FileName);
            
            // Set the file path (wwwroot/images folder)
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", fileName);
            
            // Ensure the "images" directory exists
            var directoryPath = Path.GetDirectoryName(filePath);
            
            // Check if directoryPath is null and create the directory only if it is valid
            if (directoryPath != null && !Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath); // Safe to use as directoryPath is not null here
            }

            // Save the file to wwwroot/images
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await Image.CopyToAsync(stream);
            }

            // Save the image URL (relative path) to the database
            string imageUrl = fileName;

            // Now, save other form data and the imageUrl to your database
            var category = new Categories
            {
                Name = Name,
                Description = Description,
                Icon = Icon,
                Url = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Name.ToLower()), // Capitalize the first letter
                Image = imageUrl // Save the image URL in the database
            };

            // Add category to database (e.g., using Entity Framework)
            _context.Add(category);
            await _context.SaveChangesAsync();
        }

        Console.WriteLine("Image ImageImageImageImageImageImageImageImageImageImage");
        Console.WriteLine(Image);
        Console.WriteLine(Name);
        Console.WriteLine(Description);
        Console.WriteLine(Icon);

        return RedirectToAction("Categories"); // Redirect after form submission
    }




    public async Task<IActionResult> Categories()
    {
        var categories = await _context.Categories.ToListAsync();

        return View(categories);
    }

    
        
    }
}
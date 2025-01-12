using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using worldcup.Data;
using worldcup.Models;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;

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



        // Categories START #######################
        // Categories START #######################
        // Categories START #######################
        // Categories START #######################
        // Categories START #######################
        // Categories START #######################
        // Categories START #######################
        // Categories START #######################
        // Categories START #######################


        public async Task<IActionResult> CreateCategorie(string Name, string Description, string Icon, IFormFile Image)
        {
            if (Image == null && Image.Length == 0)
            {
                return Content("File Not Selected");
            }
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



            return RedirectToAction("Categories"); // Redirect after form submission
        }




        public async Task<IActionResult> Categories()
        {
            var categories = await _context.Categories.ToListAsync();

            return View(categories);
        }

        [HttpPost]
        public async Task<IActionResult> EditCategories(int id, string Name, string Description, string Icon, IFormFile Image)
        {
            // Fetch the existing category from the database
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            if (Image != null && Image.Length != 0)
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
                category.Image = imageUrl; // Handle file upload separately if necessary

            }

            // Update the fields
            category.Name = Name;
            category.Description = Description;
            category.Icon = Icon;

            // Save changes to the database
            await _context.SaveChangesAsync();

            return RedirectToAction("Categories");
        }



        [HttpPost]
        public IActionResult DeleteCategories(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Categories");
        }


        // Categories END #######################
        // Categories END #######################
        // Categories END #######################
        // Categories END #######################
        // Categories END #######################
        // Categories END #######################
        // Categories END #######################



        // Schedule START #######################
        // Schedule START #######################
        // Schedule START #######################
        // Schedule START #######################
        // Schedule START #######################
        // Schedule START #######################
        // Schedule START #######################

        // GET: Schedule
        public async Task<IActionResult> Schedule()
        {

            Console.WriteLine("schedulesschedulesschedulesschedulesschedulesschedulesschedulesschedules");
            var schedules = await _context.Schedule.ToListAsync();


            return View(schedules); 
            
        }
        // Schedule END #######################
        // Schedule END #######################
        // Schedule END #######################
        // Schedule END #######################
        // Schedule END #######################
        // Schedule END #######################
        // Schedule END #######################
        // Schedule END #######################
        // Schedule END #######################


        // Transportation Type START #######################
        // Transportation Type START #######################
        // Transportation Type START #######################
        // Transportation Type START #######################
        // Transportation Type START #######################
        // Transportation Type START #######################
        // Transportation Type START #######################
        // Transportation Type START #######################
        // Transportation Type START #######################
        public async Task<IActionResult> TransportType()
        {
            var transportation = await _context.TransportType.ToListAsync();
            return View(transportation);
        }


        public async Task<IActionResult> CreateTransportType(TransportType model){
            _context.TransportType.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("TransportType");
        }

        public async Task<IActionResult> EditTransportType(int id, TransportType model)
        {
            // Find the existing category by ID
            var existingCategory = await _context.TransportType.FindAsync(id);
            
            if (existingCategory == null)
            {
                // Return a 404 error or an appropriate response if the category is not found
                return NotFound();
            }

            // Update the properties of the existing category
            existingCategory.Name = model.Name;

            // Save the changes to the database
            _context.TransportType.Update(existingCategory);
            await _context.SaveChangesAsync();

            // Redirect back to the Transportation view
            return RedirectToAction("TransportType");
        }



        public async Task<IActionResult> DeleteTransportType(int id)
        {
            // Find the record by its ID
            var transportation = await _context.TransportType.FindAsync(id);
            
            if (transportation == null)
            {
                // Return a 404 error or an appropriate response if the record is not found
                return NotFound();
            }

            // Remove the record from the database
            _context.TransportType.Remove(transportation);
            await _context.SaveChangesAsync();

            // Redirect to the Transportation view
            return RedirectToAction("TransportType");
        }


        // Transportation Type END #######################
        // Transportation Type END #######################
        // Transportation Type END #######################
        // Transportation Type END #######################
        // Transportation Type END #######################
        // Transportation Type END #######################
        // Transportation Type END #######################



        // Transportation START #######################
        // Transportation START #######################
        // Transportation START #######################
        // Transportation START #######################
        // Transportation START #######################
        // Transportation START #######################
        // Transportation START #######################
        // Transportation START #######################
        // Transportation START #######################
        public async Task<IActionResult> Transportation()
        {
            var transportation = await _context.Transport.ToListAsync();
            Console.WriteLine("transportation");
            Console.WriteLine(transportation);
            return View(transportation);
        }


        public async Task<IActionResult> CreateTransport(Transport model){
            _context.Transport.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("TransportType");
        }

        public async Task<IActionResult> EditTransport(int id, Transport model)
        {
            // Find the existing category by ID
            var existingCategory = await _context.Transport.FindAsync(id);
            
            if (existingCategory == null)
            {
                // Return a 404 error or an appropriate response if the category is not found
                return NotFound();
            }

            // Update the properties of the existing category
            existingCategory.Name = model.Name;

            // Save the changes to the database
            _context.Transport.Update(existingCategory);
            await _context.SaveChangesAsync();

            // Redirect back to the Transportation view
            return RedirectToAction("TransportType");
        }



        public async Task<IActionResult> DeleteTransport(int id)
        {
            // Find the record by its ID
            var transportation = await _context.Transport.FindAsync(id);
            
            if (transportation == null)
            {
                // Return a 404 error or an appropriate response if the record is not found
                return NotFound();
            }

            // Remove the record from the database
            _context.Transport.Remove(transportation);
            await _context.SaveChangesAsync();

            // Redirect to the Transportation view
            return RedirectToAction("TransportType");
        }


        // Transportation END #######################
        // Transportation END #######################
        // Transportation END #######################
        // Transportation END #######################
        // Transportation END #######################
        // Transportation END #######################
        // Transportation END #######################

    }

}
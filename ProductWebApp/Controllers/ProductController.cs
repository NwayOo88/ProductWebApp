using Microsoft.AspNetCore.Mvc;
using ProductWebApp.Data;
using ProductWebApp.Models;

namespace ProductWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;

        // Constructor with dependency injection
        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        // GET: Product/Index
        // Displays the list of all products
        public async Task<IActionResult> Index()
        {
            var products = await _repo.GetAllAsync();
            return View(products);

        }

        // GET: Product/Create
        // Show the form to create a new product
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // Save new product to database
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            await _repo.AddAsync(product);
            return RedirectToAction("Index");
        }

        // GET: Product/Edit/{id}
        // Show the form to edit an existing product
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _repo.GetByIdAsync(id);
            if (product == null) return NotFound();
            return View(product);
        }

        // POST: Product/Edit
        // Update the product in the database
        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            await _repo.UpdateAsync(product);
            return RedirectToAction("Index");
        }

        // GET: Product/Delete/{id}
        // Show the confirmation page to delete a product
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _repo.GetByIdAsync(id);
            if (product == null) return NotFound();
            return View(product);
        }

        // POST: Product/Delete
        // Delete the product from the database
        [HttpPost]
        public async Task<IActionResult> Delete(Product product)
        {
            await _repo.DeleteAsync(product.Id);
            return RedirectToAction("Index");
        }
    }
}

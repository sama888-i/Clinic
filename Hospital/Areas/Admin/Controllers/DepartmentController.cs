using Hospital.DataAccsess;
using Hospital.Models;
using Hospital.ViewModels.Department;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DepartmentController(HospitalDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(await _context.Departments.ToListAsync());
        }
        public IActionResult  Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DepartmentCreateVM vm)
        {
            Department department = new Department
            {
                Name = vm.Name
            };
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
         
        }
        [HttpPost]
        public async Task<IActionResult>Update(DepartmentUpdateVM vm,int?id)
        {
            if (!id.HasValue) return BadRequest();
            var data = await _context.Departments.FindAsync(id.Value);
            if (data is null) return NotFound();
            data.Name = vm.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));                                      
        }
        public async Task<IActionResult>Delete(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var data = await _context.Departments.FindAsync(id.Value);
            if (data is null) return NotFound();
            _context.Departments.Remove(data);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
                
            
        }
    }
}

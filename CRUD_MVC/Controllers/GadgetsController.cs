using CRUD_MVC.Data;
using CRUD_MVC.Data.Entities;
using CRUD_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC.Controllers
{
    public class GadgetsController : Controller
    {
        private readonly MyDbContext _myDbContext;
        public GadgetsController(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var allGadtets = await _myDbContext.Gadgets.OrderByDescending(_ => _.Id).ToListAsync();
            var model = new GadgetsContainerVm

            {
                AllGadgets = allGadtets
            };
            return View("Index", model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Gadgets model)
        {
       
            _myDbContext.Gadgets.Add(model);
            await _myDbContext.SaveChangesAsync();
            return RedirectToAction("All");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var gadget = await _myDbContext.Gadgets.Where(_ => _.Id == id).FirstOrDefaultAsync();
            if (gadget == null)
            {
                return NotFound();
            }
            return View("Edit", gadget);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Gadgets modelToUpdate)
        {
            _myDbContext.Update(modelToUpdate);
            await _myDbContext.SaveChangesAsync();
            return RedirectToAction("All");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var gadgetToDelete = await _myDbContext.Gadgets.Where(_ => _.Id == id).FirstOrDefaultAsync();
            if (gadgetToDelete != null)
            {
                _myDbContext.Gadgets.Remove(gadgetToDelete);
                await _myDbContext.SaveChangesAsync();
            }
            return RedirectToAction("All");
        }

    }
}


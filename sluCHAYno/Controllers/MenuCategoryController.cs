using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sluCHAYno.ViewModels;

namespace sluCHAYno.Controllers
{
    public class MenuCategoryController : Controller
    {
        private readonly EFContext _repository;

        public MenuCategoryController(EFContext repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index(int id)
        {
            var items = _repository.MenuItems.Where(x => x.CategoryId == id).ToList();
            var name = _repository.MenuCategories.FirstOrDefault(x => x.Id == id).Name;

            var model = new MenuCategoryVm()
            {
                Name = name,
                menuItems = items
            };

            return View(model);
        }
    }
}

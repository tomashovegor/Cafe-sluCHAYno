using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sluCHAYno.Models;
using sluCHAYno.ViewModels;

namespace sluCHAYno.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly EFContext _repository;

        public MenuItemController(EFContext repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index(int id)
        {
            var model = _repository.MenuItems.Where(x => x.Id == id).Select(x => new MenuItemVm
            {
                Name = x.Name,
                Description = x.Description,
                MaxPrice = x.MaxPrice,
                MinPrice = x.MinPrice,
                ImageName = x.ImageName,
                CategoryId = x.CategoryId
            }).FirstOrDefault();

            return View(model);
        }
    }
}

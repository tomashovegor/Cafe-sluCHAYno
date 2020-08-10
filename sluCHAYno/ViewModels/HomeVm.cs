using sluCHAYno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sluCHAYno.ViewModels
{
    public class HomeVm
    {
        public IList<MenuCategory> MenuCategories = new List<MenuCategory>();

        public IList<MenuItem> MenuItems = new List<MenuItem>();
    }
}

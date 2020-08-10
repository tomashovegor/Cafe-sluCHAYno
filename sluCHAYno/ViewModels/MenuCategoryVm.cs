using sluCHAYno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sluCHAYno.ViewModels
{
    public class MenuCategoryVm
    {
        public string Name { get; set; }

        public IList<MenuItem> menuItems = new List<MenuItem>();
    }
}

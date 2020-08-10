using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sluCHAYno.Models
{
    public class MenuCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<MenuItem> MenuItems = new List<MenuItem>();
    }
}

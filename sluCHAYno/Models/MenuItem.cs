using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sluCHAYno.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageName { get; set; }

        public int MaxPrice { get; set; }

        public int MinPrice { get; set; }

        public int CategoryId { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genex.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public bool IsPublic { get; set; }

        public bool IsDelete { get; set; }


        public Category? Category { get; set; }

        public int? CategoryId { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public DateTime DateUpdated { get; set; }
    }
}


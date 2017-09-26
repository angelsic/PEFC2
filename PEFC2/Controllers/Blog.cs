﻿using PEFC2.Models;
using System;
using System.Collections.Generic;

namespace PEFC2.Controllers
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}


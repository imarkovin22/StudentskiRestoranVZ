﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiResoranVŽ.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrderItemId { get; set; }
        public string ReviewText { get; set; }
    }
}

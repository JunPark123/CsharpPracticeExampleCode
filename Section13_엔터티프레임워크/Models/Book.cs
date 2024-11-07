﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Section13_엔터티프레임워크.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublishedYear {  get; set; }
        public virtual Author Author { get; set; }
    }
}

﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Quete_MVC.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}

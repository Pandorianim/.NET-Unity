﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace l10z1.ViewModels
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "To short name")]
        [MaxLength(255, ErrorMessage = " To long name, do not exceed")]
        public string Name { get; set; }
        [Required]
        [Range(0, 1000000)]
        public double Price { get; set; }

        public int? CategoryId { get; set; }

        public IFormFile? FormFile { get; set; }
    }
}

using l10z1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace l10z1.ViewModels
{
    public class CartItemViewModel
    {
        [Required]
        public int ArticleId { get; set; }
        [Required]
        public Article Article { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be positive.")]
        public int Quantity { get; set; }
    }
}
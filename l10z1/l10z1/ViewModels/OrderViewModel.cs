using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using l10z1.ViewModels;

namespace l10z1.ViewModels
{
    public class OrderViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Payment { get; set; }
        public IEnumerable<CartItemViewModel> Items {get; set; }
    }
}

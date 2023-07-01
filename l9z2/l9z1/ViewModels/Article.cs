using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace l9z1.ViewModels
{
    public enum Category
    {
        Pieczyw, Nabiał, Mięso, Alkohol
    }
    public class Article
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage="To short name")]
        [Display(Name="Nazwa")]
        [MaxLength(20,ErrorMessage =" To long name, do not exceed {0}")]
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ExpirationDate { get; set; }
        public Article()
        {

        }
        public Article(int id, string name, double price, Category category, DateTime expirationDate)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.ExpirationDate = expirationDate;
        }
        public Article(string name, double price, Category category, DateTime expirationDate)
        {
            this.Id = 0;
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.ExpirationDate = expirationDate;
        }
    }

}

using l9z1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9z1.DataContext
{
    public class ArticlesContextL : IArticlesContextL
    {
        List<Article> articles = new List<Article>() {
            new Article(0, "Bułka", 2.35, Category.Pieczyw,new DateTime()),
            new Article(1, "Piwo",2.50, Category.Alkohol,new DateTime(2000,3,22))
        };


        public void AddArticle(Article art)
        {
            int nextNumber;
            if (!articles.Any())
            {
                nextNumber = 0;
            }
            else
            {
                nextNumber = articles.Max(s => s.Id) + 1;
            }
            art.Id = nextNumber;
            articles.Add(art);
        }

        public Article GetArticle(int id)
        {
            return articles.FirstOrDefault(s => s.Id == id);
        }

        public List<Article> GetArticles()
        {
            return articles; // or make a clone of list of students
        }

        public void RemoveArticle(int id)
        {
            Article studToRemove = articles.FirstOrDefault(s => s.Id == id);
            if (studToRemove != null)
                articles.Remove(studToRemove);
        }

        public void UpdateArticle(Article art)
        {
            Article studToUpdate = articles.FirstOrDefault(s => s.Id == art.Id);
            articles = articles.Select(s => (s.Id == art.Id) ? art : s).ToList();
        }
    }
}

using l9z1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9z1.DataContext
{
    public class ArticlesContextD : IArticlesContextL
    {
        Dictionary<int, Article> articles = new Dictionary<int, Article>() {
            {0, new Article(0, "Chleb", 5.03, Category.Pieczyw, DateTime.Now)}
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
                nextNumber = articles.Keys.Max() + 1;
            }
            art.Id = nextNumber;
            articles.Add(nextNumber, art);
        }

        public Article GetArticle(int id)
        {
            return articles[id];
        }

        public List<Article> GetArticles()
        {
            return articles.Values.ToList(); // or make a clone of list of students
        }

        public void RemoveArticle(int id)
        {
            Article studToRemove = articles[id];
            if (studToRemove != null)
                articles.Remove(id);
        }

        public void UpdateArticle(Article art)
        {
            int index = art.Id;
            articles[index]=art;
        }
    }
}

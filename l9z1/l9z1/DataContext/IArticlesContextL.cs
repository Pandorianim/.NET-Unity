using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using l9z1.ViewModels;

namespace l9z1.DataContext
{
    public interface IArticlesContextL
    {
        List<Article> GetArticles();
        Article GetArticle(int id);
        void AddArticle(Article thing);
        void RemoveArticle(int id);
        void UpdateArticle(Article thing);

    }
}

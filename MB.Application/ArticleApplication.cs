using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articlerepository;

        public ArticleApplication(IArticleRepository articlerepository)
        {
            _articlerepository = articlerepository;
        }

        public void Create(CreateArticle command)
        {;
            var article = new Article(command.Title, command.ShortDescription, command.Image,
                command.Content, command.ArticleCategoryId);
            _articlerepository.CreateAndSave(article);
        }

        public List<ArticleViewModel> GetList()
        {
           return _articlerepository.GetList();
        }
    }
}

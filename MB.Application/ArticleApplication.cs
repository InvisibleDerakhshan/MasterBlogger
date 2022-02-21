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

        public void Activate(long id)
        {
            var article =_articlerepository.Get(id);
            article.Activate();
            _articlerepository.Save();
        }

        public void Create(CreateArticle command)
        {;
            var article = new Article(command.Title, command.ShortDescription, command.Image,
                command.Content, command.ArticleCategoryId);
            _articlerepository.CreateAndSave(article);
        }

        public void Edit(EditArticle command)
        {
            var article = _articlerepository.Get(command.Id);
            article.Edit(command.Title,command.ShortDescription,
                command.Image,command.Content,command.ArticleCategoryId);
            _articlerepository.Save();
        }

        public EditArticle Get(long id)
        {
            var article = _articlerepository.Get(id);
            return new EditArticle
            {
                Id=article.Id,
                Title = article.Title,
                Image = article.Image,
                ShortDescription = article.ShortDescription,
                Content = article.Content,
                ArticleCategoryId=article.ArticleCategoryId
            };

        }

        public List<ArticleViewModel> GetList()
        {
           return _articlerepository.GetList();
        }

        public void Remove(long id)
        {
            var article = _articlerepository.Get(id);
            article.Remove();
            _articlerepository.Save();
        }

        
    }
}

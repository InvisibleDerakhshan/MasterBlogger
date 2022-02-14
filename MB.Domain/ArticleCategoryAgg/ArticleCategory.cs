using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg.Services;
using System;
using System.Collections.Generic;

namespace MB.Domain.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public ArticleCategory(string title ,IArticleCategoryValidatorService validatorService)
        {
          GuardAgianstEmptyTitle(title);
            validatorService.CheckThatThisRecordAlreadyExists(title);
            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
            Articles= new List<Article>();
        }

        public long Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }
        public ICollection<Article> Articles { get;  set; }

        public void Rename(string title)
        {
            GuardAgianstEmptyTitle(title);
            Title =title;
        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void Activate()
        {
            IsDeleted=false;
        }
        public void GuardAgianstEmptyTitle(string title)
        {
            if(string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException();
        }
    }
}

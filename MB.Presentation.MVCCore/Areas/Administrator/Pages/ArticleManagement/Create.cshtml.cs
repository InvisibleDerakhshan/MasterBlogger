using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using MB.Application.Contracts.Article;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.ArticleManagement
{
    public class CreateModel : PageModel
    {
        public List<SelectListItem> ArticleCategories { get; set; }

        private readonly IArticleApplication _articleApplication;
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public CreateModel(IArticleCategoryApplication articleCategoryApplication, IArticleApplication articleApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
            _articleApplication = articleApplication;
        }

        public void OnGet()
        {
            ArticleCategories = _articleCategoryApplication.List().Where(x=>x.IsDeleted==false)
                .Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();
        }

        public RedirectToPageResult OnPost(CreateArticle command)
        {
            _articleApplication.Create(command);
            return RedirectToPage("./List");
        }
    }
}
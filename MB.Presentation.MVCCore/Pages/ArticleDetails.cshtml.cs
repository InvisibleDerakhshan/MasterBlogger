using MB.Infrastructure.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleQueryView Article { get; set; }
        private readonly IArticleQuery _articlequery;

        public ArticleDetailsModel(IArticleQuery articlequery)
        {
            _articlequery = articlequery;
        }

        public void OnGet(long id)
        {
            Article= _articlequery.GetArticle(id);
        }
    }
}

using MB.Application.Contracts.Comment;
using MB.Infrastructure.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleQueryView Article { get; set; }

        private readonly IArticleQuery _articlequery;
        private readonly ICommentApplication _commentApplication;

        public ArticleDetailsModel(IArticleQuery articlequery, ICommentApplication commentApplication)
        {
            _articlequery = articlequery;
            _commentApplication = commentApplication;
        }

        public void OnGet(long id)
        {
            Article= _articlequery.GetArticle(id);
        }

        public RedirectToPageResult OnPost(AddComment command)
        {
            _commentApplication.Add(command);
            return RedirectToPage("./ArticleDetails", new {id = command.ArticleId});
        }
    }
}

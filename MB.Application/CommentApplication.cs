using MB.Application.Contracts.Comment;
using MB.Domain.CommentAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly ICommentRepository _commentrepository;

        public CommentApplication(ICommentRepository commentrepository )
        {
            _commentrepository = commentrepository;
        }
    }
}

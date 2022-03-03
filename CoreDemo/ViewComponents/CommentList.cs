using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    UserCommentID=1,
                    UserName="Ishak"
                },
                new UserComment
                {
                    UserCommentID=2,
                    UserName="Filiz"
                },
                new UserComment
                {
                    UserCommentID=3,
                    UserName="Murat"
                }
            };
            return View(commentValues);
        }
    }
}

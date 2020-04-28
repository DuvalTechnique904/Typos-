using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;


namespace SportsStore.Controllers
{
    public class NewCommentController : Controller
    {
        private INewCommentRepository repository;
        public NewCommentController(INewCommentRepository repoService)
        {
            repository = repoService;
        }

        public ViewResult PostComment() => View(repository.NewComments.Where(o => !o.Approved));

        [HttpPost]
        public IActionResult MarkApproved(int ID)
        {
            NewComment newComment = repository.NewComments
                .FirstOrDefault(o => o.ID == ID);
            if (newComment != null)
            {
                newComment.Approved = true;
                repository.ApproveComment(newComment);
            }
            return RedirectToAction(nameof(PostComment));
        }

        [HttpPost]
        public IActionResult PostComment(NewComment newComment)
        {
            if(ModelState.IsValid)
            {
                repository.ApproveComment(newComment);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(newComment);
            }
        }

        public ViewResult Completed()
        {
            return View();
        }
    }
}

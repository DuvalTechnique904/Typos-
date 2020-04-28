using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class EFNewCommentRepository : INewCommentRepository
    {
        private ApplicationDbContext context;
        public EFNewCommentRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        
        public IEnumerable<NewComment> NewComments => context.NewComments;
        public void ApproveComment(NewComment newComment)
        {
            if (newComment.ID == 0)
            {
                context.NewComments.Add(newComment);
            }
            context.SaveChanges();
        }
    }
}

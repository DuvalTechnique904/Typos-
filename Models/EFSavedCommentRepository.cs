using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFSavedCommentRepository : ISavedCommentRepository
    {
        private ApplicationDbContext context;
        public EFSavedCommentRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<SavedComment> SavedComments => context.SavedComments;
    }
}

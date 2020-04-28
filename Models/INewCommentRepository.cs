using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface INewCommentRepository
    {
        IEnumerable<NewComment> NewComments { get; }

        void ApproveComment(NewComment comment);
    }
}

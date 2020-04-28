using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStore.Models;

namespace SportsStore.Models.ViewModels
{
    public class SavedCommentsListViewModel
    {
        public IEnumerable<SavedComment> SavedComments { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}

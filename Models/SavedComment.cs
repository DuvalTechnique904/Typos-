using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;

namespace SportsStore.Models
{
    public class SavedComment
    {
        [Key]
        public int CommentId { get; set; }

        public string Name { get; set; }

        public string Body { get; set; }

    }
}

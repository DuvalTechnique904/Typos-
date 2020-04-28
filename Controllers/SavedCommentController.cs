using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{ 
    public class SavedCommentController : Controller
    {
        private ISavedCommentRepository repository;
        public int PageSize = 4;

        public SavedCommentController(ISavedCommentRepository repo)
        {
            repository = repo;
        }

        public ViewResult ListComments(int page = 1)
            => View(new SavedCommentsListViewModel
            {
                SavedComments = repository.SavedComments
                           .OrderBy(p => p.CommentId)
                           .Skip((page - 1) * PageSize)
                           .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.SavedComments.Count()
                }
            });
        }
    }



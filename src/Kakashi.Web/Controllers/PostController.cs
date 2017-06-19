using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kakashi.Domain.投稿;
using Kakashi.Web.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kakashi.Web.Controllers
{
    public class PostController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            投稿 post = 投稿.新規("●●について", "まるまるまる");
            投稿者 author = 投稿者.新規作成("○○さん");

            return View(PostViewModel.Create(post, author));
        }
    }
}

using Kakashi.Domain.投稿;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kakashi.Web.Models
{
    public class PostViewModel
    {
        public string Title { get; private set; }

        public string Author { get; private set; }

        public string Content { get; private set; }

        public static PostViewModel Create(投稿 post, 投稿者 author)
        {
            if (post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }

            if (author == null)
            {
                throw new ArgumentNullException(nameof(author));
            }

            return new PostViewModel()
            {
                Title = post.タイトルを見る(),
                Content = post.内容を見る(),
                Author = author.名前を見る()
            };
        }
    }
}

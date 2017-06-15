using System;
using System.Collections.Generic;
using System.Text;

namespace Kakashi.Domain.投稿
{
    public class 投稿
    {
        private タイトル タイトル;
        private 内容 内容;

        private 投稿(string タイトル, string 内容)
        {
            this.タイトル = new タイトル(タイトル);
            this.内容 = new 内容(内容);
        }

        public static 投稿 新規(string タイトル, string 内容)
        {
            return new 投稿(タイトル, 内容);
        }
    }
}

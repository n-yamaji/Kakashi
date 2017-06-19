using System;
using System.Collections.Generic;
using System.Text;

namespace Kakashi.Domain.投稿
{
    public class 投稿者
    {
        private 投稿者名 名前;
        private 投稿リスト 自分の投稿;

        private 投稿者(string 名前)
        {
            this.名前 = new 投稿者名(名前);
            this.自分の投稿 = new 投稿リスト();
        }

        public static 投稿者 新規作成(string 名前)
        {
            return new 投稿者(名前);
        }

        public string 名前を見る()
        {
            return 名前.ToString();
        }
    }
}

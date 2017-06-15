using System;
using System.Collections.Generic;
using System.Text;

namespace Kakashi.Domain.投稿
{
    class 投稿リスト
    {
        private List<投稿> 投稿 = new List<投稿>();

        public void 加える(投稿 投稿)
        {
            this.投稿.Add(投稿);
        }

        public void 除く(投稿 投稿)
        {
            this.投稿.Remove(投稿);
        }
    }
}

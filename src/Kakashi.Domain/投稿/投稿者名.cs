using System;
using System.Collections.Generic;
using System.Text;

namespace Kakashi.Domain.投稿
{
    class 投稿者名
    {
        private static readonly int MAX_SIZE = 30;

        private string name;
        public 投稿者名(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"{nameof(投稿者名)}が入力されていません。");
            }

            if (name.Length > MAX_SIZE)
            {
                throw new ArgumentException($"{nameof(投稿者名)}は{MAX_SIZE}以内にしてください。");
            }

            this.name = name;
        }
    }
}

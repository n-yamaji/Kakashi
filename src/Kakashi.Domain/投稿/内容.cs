using System;
using System.Collections.Generic;
using System.Text;

namespace Kakashi.Domain.投稿
{
    class 内容
    {
        private static readonly int MAX_SIZE = 1000;

        private string value;
        public 内容(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(内容)}が入力されていません。");
            }

            if (value.Length > MAX_SIZE)
            {
                throw new ArgumentException($"{nameof(内容)}は{MAX_SIZE}以内にしてください。");
            }

            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}

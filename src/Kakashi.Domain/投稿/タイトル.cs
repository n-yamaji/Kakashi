using System;
using System.Collections.Generic;
using System.Text;

namespace Kakashi.Domain.投稿
{
    class タイトル
    {
        private static readonly int MAX_SIZE = 30;

        private string value;
        public タイトル(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(タイトル)}が入力されていません。");
            }

            if (value.Length > MAX_SIZE)
            {
                throw new ArgumentException($"{nameof(タイトル)}は{MAX_SIZE}以内にしてください。");
            }

            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}

namespace Kakashi.Domain.Art
{
    class 術者
    {
        public string 名前 { get; private set; }
        public ICollection<術> 使える術 { get; private set; }

        private 術者(string 名前) : this(名前, new List<術>()){ }
        private 術者(string 名前, ICollection<術> 使える術)
        {
            名前 = 名前;
            使える術 = new List<術>(使える術);
        }

        public static 術者 登場(string 名前)
        {
            return new 術者(名前);
        }

        public static 再登場(string 名前, ICollection<術> 使える術)
        {
            return new 術者(名前, 使える術);
        }
    }
}
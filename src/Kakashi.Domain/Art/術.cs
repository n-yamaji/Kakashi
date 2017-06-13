namespace Kakashi.Domain.Art
{
    public class 術
    {
        public 術名 術名 { get; private set; } 
        public 印 印 { get; private set; }
        public 術者 術者 { get; private set; }

        private 術(術名 術名, 印 印, 術者 術者)
        {
            this.術名 = 術名;
            this.印 =印;
            this.術者 = 術者;
        }

        public static 術 新術(術名 術名, 印 印, 術者 術者) 
        {
            return new 術(術名, 印, 術者);
        }

        public 術 コピー(術 術)
        {
            return new 術(術.術名, 術.印, this.術者);
        }
    }
}
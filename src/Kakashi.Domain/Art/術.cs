namespace Kakashi.Domain.Art
{
    public class 術
    {
        public 術名 術名 { get; private set; } 
        public 印 印 { get; private set; }

        private 術(術名 術名, 印 印)
        {
            this.術名 = 術名;
            this.印 =印;
        }

        public static 術 新術(術名 術名, 印 印) 
        {
            return new 術(術名, 印);
        }
    }
}
namespace Kakashi.Domain.Art
{
    public class 術名
    {
        private string value;

        private 術名(string 術名)
        {
            value = 術名;
        }

        public static 術名 命名(string 術名)
        {
            return new 術名(術名);
        }
    }    
}
namespace Kakashi.Domain.Art
{
    public class 印
    {
        private string value;

        private 印(string 印)
        {
            value = 印;
        }

        public static 印 組む(string 印)
        {
            return new 印(印);
        }
    }
}
namespace Tennis
{
    public class Tennis
    {
        //public enum Player
        //{
        //    PlayerA,
        //    PlayerB
        //}

        //public static bool IsLeapYear(int i)
        //{

        //    throw new System.NotImplementedException();
        //}
        public static string Scores(string winOrder)
        {
            if(string.IsNullOrEmpty(winOrder))
                return "0:0";
            return "15:0";
        }
    }
}
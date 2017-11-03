﻿namespace Tennis
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
            int PointOfPlayerA = 0;
            int PointOfPlayerB = 0;
            var scores = string.Empty;
            foreach (var winPlayer in winOrder)
            {
                if (winPlayer == 'A')
                    PointOfPlayerA ++;
                else if (winPlayer == 'B')
                    PointOfPlayerB ++;
            }

            scores = string.Format("{0}:{1}", TranslateScore(PointOfPlayerA), TranslateScore(PointOfPlayerB));
            return scores;
        }

        private static string TranslateScore(int points)
        {
            switch (points)
            {
                case 0:
                    return "0";
                case 1:
                    return "15";
                case 2:
                    return "30";
                case 3:
                    return "40";
                default:
                    return "0";
            }
        }
    }
}
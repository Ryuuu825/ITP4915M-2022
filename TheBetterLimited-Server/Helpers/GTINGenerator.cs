namespace TheBetterLimited_Server.Helpers
{
    public static class GTINGenerator
    {
        // generate a EAN-13 GTIN code
        public static string Get(Country Area , string  ManufactorCode , string GoodsSequence)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0:D3}{1:D5}{2:D5}", (int) Area, ManufactorCode, GoodsSequence);

            // check sum
            int checkSum = 0;
            for (int i = 0; i < 12; i++)
            {
                checkSum += (int) sb[i] * (i % 2 == 0 ? 3 : 1);
            }
            checkSum = (10 - (checkSum % 10)) % 10;
            sb.Append(checkSum);
            return sb.ToString();
        }

        public static string L(string id)
        {
            return Get(Country.HK , "0000" , id);
        }
    }

    public enum Country
    {
        HK = 489,
        TW = 481,
        CN = 690,
        JP = 45,
        US = 00 
    }
}
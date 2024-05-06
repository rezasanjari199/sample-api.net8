namespace ghabzinow
{
    public static class Constants
    {
        public const string Audiance = "https://api.ghabzino.ir/";
        public const string Issuer = Audiance;
        public const string Secret = "qrU58sp3fP8B71GV2aymcnqLAC6UEfS3f1AGM5emV482HvS0oqGbVHLyeowpZcmljEID3PYNfd1GjGYk38GEUBqIgfgSX9WJm7ECdnh6Kivx7xvIZtPfZImDKmeBfeyGUHjMfpO1KxMrqihSv1FXVPCdZmX8ugaH";
        public const string ConnectionSting = "Data Source=DESKTOP-2JR4C6K\\MSSQLSERVER01;Initial Catalog=ghabzinow-db;Integrated Security=True;TrustServerCertificate=True";
    }
    //public static class PublicBillConstants
    //{
    //    public const string ElectricityConstanst = "استعلام قبض برق";
    //}
   public enum TypePublicBill
    {
        ElectricityConstanst ,
        GasConstanst,
        WaterConstanst,
        TeleKishMobileConstanst

    }
}

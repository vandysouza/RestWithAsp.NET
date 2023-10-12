namespace RestWithASPNET.Configurations
{
    public class TokenConfiguration
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string Secret { get; set; }
        public double Minutes { get; set; }
        public double DaysToExpiry { get; set; }
    }
}

namespace Point_of_Sale.SYSTEM.Collection.Accounts
{
    public enum AccountSecurity
    {
        NORMAL = 0,
        ADMIN = 1
    };

    public class Account : IAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string StringID { get; set; }
        public AccountSecurity Security { get; set; }
    }
}

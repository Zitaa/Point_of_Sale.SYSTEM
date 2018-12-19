namespace Point_of_Sale.SYSTEM.Collection.Accounts
{
    internal interface IAccount
    {
        string Username { get; set; }
        string Password { get; set; }
        string StringID { get; set; }
        AccountSecurity Security { get; set; }
    }
}

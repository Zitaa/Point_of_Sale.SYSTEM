using Point_of_Sale.SYSTEM.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.SYSTEM.Collection.Accounts
{
    public enum AccountSecurity
    {
        Normal,
        Admin
    };

    public class Account : IAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string StringID { get; set; }
        public AccountSecurity Security { get; set; }
    }
}

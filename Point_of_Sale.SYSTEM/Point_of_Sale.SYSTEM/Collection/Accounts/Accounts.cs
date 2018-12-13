﻿using Point_of_Sale.SYSTEM.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.SYSTEM.Collection.Accounts
{
    public static class Accounts
    {
        private static List<Account> accounts;

        static Accounts()
        {
            if (File.Exists(Database.ACCOUNT_PATH))
            {
                accounts = Database.LoadAccounts(Database.ACCOUNT_PATH).ToList();
            }
            else
            {
                accounts = new List<Account>();
            }
        }

        public static void SaveAccounts()
        {
            Database.SaveAccounts(accounts, Database.ACCOUNT_PATH);
        }

        public static Account CreateAccount(string username, string password, AccountSecurity security)
        {
            string stringID = username.Replace(" ", string.Empty);
            stringID = stringID.ToLower();

            Account newAccount = new Account()
            {
                Username = username,
                Password = password,
                StringID = stringID,
                Security = security
            };
            accounts.Add(newAccount);
            SaveAccounts();
            return newAccount;
        }

        public static Account GetAccount(string stringID)
        {
            IEnumerable<Account> result = from acc in accounts
                                          where acc.StringID == stringID
                                          select acc;

            Account account = result.FirstOrDefault();
            if (account is null) return null;
            return account;
        }
    }
}
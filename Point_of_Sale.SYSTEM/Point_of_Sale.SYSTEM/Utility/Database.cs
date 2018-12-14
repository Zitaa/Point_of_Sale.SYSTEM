using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using Point_of_Sale.SYSTEM.Collection;
using Point_of_Sale.SYSTEM.Collection.Accounts;

namespace Point_of_Sale.SYSTEM.Utility
{
    public static class Database
    {
        public static List<Dish> allDishes = new List<Dish>();
        public static List<Ingredient> allIngredients = new List<Ingredient>();

        public static string INGREDIENT_PATH;
        public static string DISH_PATH;
        public static string ACCOUNT_PATH;
        public static string SETTINGS_PATH;

        public static void Init()
        {
            INGREDIENT_PATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Data\\Ingredients.json";
            DISH_PATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Data\\Dishes.json";
            ACCOUNT_PATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Data\\Accounts.json";
            SETTINGS_PATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Data\\Settings.json";
        }

        public static IEnumerable<Ingredient> LoadIngredients(string path)
        {
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                return allIngredients = JsonConvert.DeserializeObject<List<Ingredient>>(json);
            }
            else return null;
        }

        public static void SaveIngredients(IEnumerable<Ingredient> ingredients, string path)
        {
            var settings = new JsonSerializerSettings() { ContractResolver = new ContractResolver() };
            var json = JsonConvert.SerializeObject(ingredients, Formatting.Indented, settings);
            File.WriteAllText(path, json);
        }

        public static IEnumerable<Dish> LoadDishes(string path)
        {
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                return allDishes = JsonConvert.DeserializeObject<List<Dish>>(json);
            }
            else return null;
        }

        public static void SaveDishes(IEnumerable<Dish> dishes, string path)
        {
            var settings = new JsonSerializerSettings() { ContractResolver = new ContractResolver() };
            var json = JsonConvert.SerializeObject(dishes, Formatting.Indented, settings);
            File.WriteAllText(path, json);
        }

        public static IEnumerable<Account> LoadAccounts(string path)
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<List<Account>>(json);
            }
            return null;
        }

        public static void SaveAccounts(IEnumerable<Account> accounts, string path)
        {
            var settings = new JsonSerializerSettings() { ContractResolver = new ContractResolver() };
            string json = JsonConvert.SerializeObject(accounts, Formatting.Indented, settings);
            File.WriteAllText(path, json);
        }
    }

    public class ContractResolver : DefaultContractResolver
    {
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                            .Select(p => base.CreateProperty(p, memberSerialization))
                        .Union(type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                                   .Select(f => base.CreateProperty(f, memberSerialization)))
                        .ToList();
            props.ForEach(p => { p.Writable = true; p.Readable = true; });
            return props;
        }
    }
}

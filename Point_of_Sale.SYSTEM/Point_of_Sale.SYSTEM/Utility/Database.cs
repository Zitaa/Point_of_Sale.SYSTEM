using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using Point_of_Sale.SYSTEM.Collection;
using System.Collections;

namespace Point_of_Sale.SYSTEM.Utility
{
    public static class Database
    {
        public static List<Dish> allDishes = new List<Dish>();
        public static List<Ingredient> allIngredients = new List<Ingredient>();

        public const string INGREDIENT_PATH = @"C:\Users\nicklas.haggqvist\Desktop\Point_of_Sale.SYSTEM\Data\Ingredients.json";
        public const string DISH_PATH = @"C:\Users\nicklas.haggqvist\Desktop\Point_of_Sale.SYSTEM\Data\Dishes.json";
        public const string SETTINGS_PATH = @"C:\Users\nicklas.haggqvist\Desktop\Point_of_Sale.SYSTEM\Data\settings.json";

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
            var json = JsonConvert.SerializeObject(allIngredients, Formatting.Indented, settings);
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

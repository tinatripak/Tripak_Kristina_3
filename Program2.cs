using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace лаба_3._2
{
    /*
    Написати програму згідно виданого завдання використовуючи словники Dictionary в C#. 
    Якщо результатом виконання програми є словник, зберегти цей результат у JSON файл

    Дано кілька словників з різними значеннями ключів цілих чисел. Вивести один словник,
    значення ключів якого складатимуть суму цих значень вхідних словників.
    Вхідні словники: [{'item': 'item1', 'amount': 400}, {'item': 'item2', 'amount': 300}, 
    {'item': 'item1', 'amount': 750}]. Результат: {'item1': 1150, 'item2': 300}
     */
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Dictionary<string, int> dictionary1 = new Dictionary<string, int>()
            {
                {"item1", 400}
            };
            Dictionary<string, int> dictionary2 = new Dictionary<string, int>()
            {
                { "item2", 300}
            };
            Dictionary<string, int> dictionary3 = new Dictionary<string, int>()
            {
                { "item1", 750}
            };
            Dictionary<int, Dictionary<string, int>> all = new Dictionary<int, Dictionary<string, int>>
            {
                { 0, dictionary1 },
                { 1, dictionary2 },
                { 2, dictionary3 }
            };
            Dictionary<string, int> result1 = new Dictionary<string, int>();
            foreach (var keyValue in all)
            {
                foreach (var item in keyValue.Value)
                {
                    if (result1.ContainsKey(item.Key))
                    {
                        result1[item.Key] += item.Value;
                    }
                    else
                    {
                        result1.Add(item.Key, item.Value);
                    }
                }
            }
            File.WriteAllText(@"C:\Users\Asus\source\repos\лаба 3.2\лаба 3.2\bin\Debug\numbers.json", JsonConvert.SerializeObject(result1));
            using (StreamWriter file = File.CreateText(@"C:\Users\Asus\source\repos\лаба 3.2\лаба 3.2\bin\Debug\numbers.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, result1);
            }
            Console.ReadKey();
        }
    }
}
//Dictionary<string, int> result = dictionary1.Concat(dictionary2).ToDictionary(x => x.Key, x => x.Value);
//result["item1"] = dictionary1["item1"] + dictionary3["item1"];
//foreach (KeyValuePair<string, int> keyValue in result)
//{
//    Console.WriteLine(keyValue.Key + " : " + keyValue.Value);
//}

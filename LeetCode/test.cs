using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class test
    {
        private readonly Random _random = new Random();

        public String TestMethod(int numberOfShops)
        {
         
         



            List<shops> listShops = new();
            List<int> listTotals = new();
            Dictionary<string,int> quarterTotal = new();

            for (int i = 0; i < numberOfShops; i++)
            {
                shops shop = new shops($"shopname{i}",AddRandomData());
                listShops.Add(shop);
            }

            foreach(shops shop in listShops)
            {
                              
                if(quarterTotal.Count == 0)
                {
                    quarterTotal = shop.Quarters;
                }
                else
                {
                  quarterTotal = quarterTotal.Concat(shop.Quarters).GroupBy(k => k.Key).ToDictionary(o => o.Key, o => o.Sum(v => v.Value));
                }

            }
            shops shopMaxProfit = listShops.OrderByDescending(shop => shop.Quarters.Sum(x => x.Value)).First();

            var maxValue = quarterTotal.MaxBy(kvp => kvp.Value).Key;


            return $"Shop with greatest profit {shopMaxProfit.ShopName}  with {shopMaxProfit.Quarters.Sum(x=>x.Value)} EUR && Best Quarter is {maxValue} with total {quarterTotal[maxValue]} EUR";

   
        }
        private Dictionary<string, int> AddRandomData()
        {
            Dictionary<string, int> Quarters = new Dictionary<string, int>();
            List<string> list = new List<string> { "Q1", "Q2", "Q3", "Q4" };
            for (int i = 0; i < list.Count; i++)
            {
                string key = list[i];
                int num = _random.Next(1000);
                Quarters.Add(key, num);
            }

            return Quarters;

        }
}
}


//dynamic test = new List<string>();
//dynamic test2 = "test";

//foreach (var item in test2)
//{
//    Console.WriteLine(item);
//}



//Console.WriteLine("Enter number of shops:");

//int rows = int.Parse(Console.ReadLine());

//int columns = 4;

//int[,] matrix = new int[rows, columns];

//for (int i = 0; i < rows; i++)

//{
//    Console.WriteLine("Enter quarters result:");
//    int[] numbers = Console.ReadLine()

//    .Split(" ")

//    .Select(int.Parse)

//    .ToArray();



//    for (int j = 0; j < columns; j++)

//    {

//        matrix[i, j] = numbers[j];

//    }

//}


//List<int> totalPerQuarter = new();
//List<int> totalPerShop = new();

//for (int j = 0; j < columns; ++j)
//{
//    int sum = 0;
//    for (int i = 0; i < rows; i++)
//    {

//        sum += matrix[i, j];
//    }
//    totalPerQuarter.Add(sum);

//}

//for (int i = 0; i < rows; ++i)
//{
//    int sum = 0;
//    for (int j = 0; j < columns; j++)
//    {

//        sum += matrix[i, j];

//    }
//    totalPerShop.Add(sum);

//}

//Console.WriteLine($" shop at row :{totalPerShop.IndexOf(totalPerShop.Max()) + 1} has highest total : {totalPerShop.Max(x => x)} && Best quarter was column {totalPerQuarter.IndexOf(totalPerQuarter.Max()) + 1} with {totalPerQuarter.Max(x => x)}");




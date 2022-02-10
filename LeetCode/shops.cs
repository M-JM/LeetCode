using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class shops
    {
    

        public string ShopName { get; set; }

        public Dictionary<string, int> Quarters { get; set; }

        public shops(string shopname, Dictionary<string,int> quarters)
        {
            ShopName = shopname;
            Quarters = quarters;
           
        }

       
            


        }


    }

using System;
using DataLibrary.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataLibrary
{
    public class Prog
    {
        static readonly string roadPath = "App_Data/roads.csv";
        static readonly string ordersPath = "App_Data/orders.csv";
        static readonly string categoryPath = "App_Data/category.csv";

        static void Main(string[] args)
        {
           
        }

        public List<Road> ReadRoad() {
            var roadStore = new RoadStore()
            {
                Path = roadPath 
            };
            var roadList = roadStore.GetCollection();
            return roadList;
        }

        public List<Order> ReadOrder() {
            var orderStore = new OrderStore() 
            { 
                Path = ordersPath
            };
            var orderList = orderStore.GetCollection();
            return orderList;
        }

        public List<Category> ReadCategory() {
            var categoryStore = new CategoryStore() 
            { 
                Path = categoryPath
            };
            var categoryList = categoryStore.GetCollection();
            return categoryList;
        }
    }
}

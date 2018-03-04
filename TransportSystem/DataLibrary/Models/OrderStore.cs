using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Models;

namespace DataLibrary.Models
{
    public class OrderStore : IStore<Order>
    {
        private List<Order> _cachedCollection;

        public string Path { get; set; }

        public List<Order> GetCollection()
        {
            if(_cachedCollection == null)
            {
                var data = File.ReadAllLines(Path);
                _cachedCollection = data
                    .Skip(1)
                    .Select(x => ConvertItem(x))
                    .ToList();
            }

            return _cachedCollection;
        }

        public Order ConvertItem(string item)
        {
            var itemList = item.Split(';');

            return new Order()
            {
                ID = Convert.ToInt32(itemList[0]),
                DistanceID = Convert.ToInt32(itemList[1]),
                CategoryID = Convert.ToInt32(itemList[2]), 
                OrderedDate = DateTime.ParseExact(itemList[3],"dd/mm/yyyy",null) ,
                Customer = itemList[4]
            };
        }


    }
}
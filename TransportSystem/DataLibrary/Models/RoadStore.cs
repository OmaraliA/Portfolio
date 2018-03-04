using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataLibrary.Models
{
    public class RoadStore : IStore<Road>
    {
        private List<Road> _cachedCollection;
        
        public string Path { get; set; }
        public List<Road> GetCollection()
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

        public Road ConvertItem(string item)
        {
            var itemList = item.Split(';');

            return new Road()
            {
                DistanceID = Convert.ToInt32(itemList[0]),
                RoadDistance = itemList[1],
                Duration = Convert.ToInt32(itemList[2])
            };
        }
    }
}
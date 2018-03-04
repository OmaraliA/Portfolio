using System.Collections.Generic;
using System;

namespace DataLibrary.Models 
{
    public class Order
    {
        public int ID {get;set;}
        public int DistanceID {get; set;}
        public int CategoryID {get; set;}   
        public DateTime OrderedDate {get; set;} 
        public string Customer {get;set;}

    }
}
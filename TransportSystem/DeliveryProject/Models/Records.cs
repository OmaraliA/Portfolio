using System.Collections.Generic;
using System;

namespace DataLibrary.Models 
{
    public class Records
    {
        public int ID {get;set;}
        public string Customer {get;set;}
        public string RoadDistance {get; set;}
        public DateTime OrderedDate {get; set;} 
        public DateTime DeliveredDate  {get; set;}   
        public string Type {get; set;} 
        public int Price {get; set;} 
        public bool inProcess {get; set;} 
     

    }
}
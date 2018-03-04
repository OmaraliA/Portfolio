using System.Collections.Generic;
using System;
using DataLibrary.Models;
using System.IO;
namespace DeliveryProject.Models 
{
    public class Write
    {
        public void WriteToFile(int ID, int DistanceID, int CategoryID, DateTime OrderedDate, string Customer)
        {
            int lines = 0;
            string path = "App_Data/orders.csv";

            using(var st = new StreamReader(path:"App_Data/orders.csv"))
            {
                lines = 0;

                while (!st.EndOfStream)
                {
                    var columns = st.ReadLine().Split(';');
                    Console.WriteLine(columns.ToString());
                    lines++;   
                }
            }
            string day = "";
            string month = "";
            if (OrderedDate.Day < 10) {
                day = "0" + OrderedDate.Day; 
            }

            else
            {
                day = OrderedDate.Day.ToString();
            }

            if (OrderedDate.Month < 10) {
                month = "0" + OrderedDate.Month; 
            }

            else {
                 month = OrderedDate.Month.ToString();
            }
            string ord  = ID + ";" + DistanceID + ";" + CategoryID + ";" + day + "/" + month + "/" +  OrderedDate.Year + ";" + Customer ;
            File.AppendAllText(path,ord + Environment.NewLine);           
        }
    }
}
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using DataLibrary.Models;
using DataLibrary;

namespace DeliveryProject.Models { 
    public class DeliveryMarket {
 
        public List<Order> GetOrder(){
            var getList = new Prog();
            var list = getList.ReadOrder();
            return list;
        }

        public List<Road> GetRoad(){
            var getList = new Prog();
            var list = getList.ReadRoad();
            return list;
        }
        
        public List<Category> GetCategory(){
            var getList = new Prog();
            var list = getList.ReadCategory();
            return list;
        }

        public List<Records> GetRecord(){
            var getList = new Prog();
            var roadList = getList.ReadRoad();
            var orderList = getList.ReadOrder();
            var categoryList = getList.ReadCategory();

            var model = new List<Records>();
            
            var join = roadList  
                                .Join(orderList,
                                    road => road.DistanceID,
                                    order => order.DistanceID,
                                    (road, order) => new 
                                    {
                                        road,
                                        order
                                    }
                                )
                                .Join(categoryList,
                                    orders => orders.order.CategoryID, 
                                    categories => categories.CategoryID,
                                    (orders,categories) => new 
                                    {
                                        orders,categories
                                    }
                                )
                                .ToList();

            foreach (var item in join)  {     
            model.Add(new Records { 
                    ID = item.orders.order.ID, 
                    RoadDistance = item.orders.road.RoadDistance,
                    OrderedDate = item.orders.order.OrderedDate,
                    DeliveredDate = item.orders.order.OrderedDate.AddDays(item.orders.road.Duration),
                    Customer = item.orders.order.Customer,
                    Type = item.categories.Type,
                    Price = item.categories.Price,
                    inProcess = true,
                });

                /*if (DeliveredDate<DateTime.Now){
                    InProcess = true;
            }*/
            }

            

            return model;
        }
          
            public List<Records> SortedPrice(){
            var getList = new Prog();
            var roadList = getList.ReadRoad();
            var orderList = getList.ReadOrder();
            var categoryList = getList.ReadCategory();

             var model = new List<Records>();

            var join = roadList  
                                .Join(orderList,
                                    road => road.DistanceID,
                                    order => order.DistanceID,
                                    (road, order) => new 
                                    {
                                        road,
                                        order
                                    }
                                )
                                .Join(categoryList,
                                    orders => orders.order.CategoryID, 
                                    categories => categories.CategoryID,
                                    (orders,categories) => new 
                                    {
                                        orders,categories
                                    }
                                )
                                .ToList();
            var sorted = join
                            .OrderBy(x =>x.categories.Price)
                            .Select( x => 
                            new {
                                ID = x.orders.order.ID, 
                                RoadDistance = x.orders.road.RoadDistance,
                                OrderedDate = x.orders.order.OrderedDate,
                                Customer = x.orders.order.Customer,
                                Type = x.categories.Type,
                                Price = x.categories.Price
                            }).ToList();

            foreach (var item in sorted)
            {
                model.Add(new Records { 
                    ID = item.ID, 
                    RoadDistance = item.RoadDistance,
                    OrderedDate = item.OrderedDate,
                    Customer = item.Customer,
                    Type = item.Type,
                    Price = item.Price
                });
            }
            return model;
    

        }
            public List<Records> GroupedName(){
            var getList = new Prog();
            var roadList = getList.ReadRoad();
            var orderList = getList.ReadOrder();
            var categoryList = getList.ReadCategory();

             var model = new List<Records>();

            var join = roadList  
                                .Join(orderList,
                                    road => road.DistanceID,
                                    order => order.DistanceID,
                                    (road, order) => new 
                                    {
                                        road,
                                        order
                                    }
                                )
                                .Join(categoryList,
                                    orders => orders.order.CategoryID, 
                                    categories => categories.CategoryID,
                                    (orders,categories) => new 
                                    {
                                        orders,categories
                                    }
                                );
                                
                          
            var sorted = join
                            .GroupBy(x=>x.orders.order.Customer)
                            .Select( x => 
                            new
                            {
                                ID = x.orders.order.ID, 
                                RoadDistance = x.orders.road.RoadDistance,
                                OrderedDate = x.orders.order.OrderedDate,
                                Customer = x.orders.order.Customer,
                                Type = x.categories.Type,
                                Price = x.categories.Price
                            }).ToList();

            foreach (var item in sorted)
            {
                model.Add(new Records { 
                    ID = item.ID, 
                    RoadDistance = item.RoadDistance,
                    OrderedDate = item.OrderedDate,
                    Customer = item.Customer,
                    Type = item.Type,
                    Price = item.Price
                });
            }
            return model;
    

        }
    }
}
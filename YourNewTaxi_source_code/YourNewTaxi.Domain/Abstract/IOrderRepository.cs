﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourNewTaxi.Domain.Entities;

namespace YourNewTaxi.Domain.Abstract
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void DeleteOrder(int orderID);
        void SaveOrder(Order newOrder);
        void UpdateOrder(Order existingOrder);
    }
}

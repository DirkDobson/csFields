﻿using System;
using System.Collections.Generic;

namespace Fields
{
  
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            System.Console.WriteLine(customer.Orders.Count);

        }
    }
}

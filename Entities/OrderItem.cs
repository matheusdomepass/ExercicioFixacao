﻿using System;
using System.Globalization;
using System.Text;

namespace ExercicioFixacao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double subTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name +
                ", $" +
                Price.ToString("F2", CultureInfo.InvariantCulture) +
                ", Quantity: " +
                Quantity +
                ", Subtotal: $" +
                subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

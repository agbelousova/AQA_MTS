namespace Shop;

using System.Collections;
using System;

public class Product
{
    public string NameProduct { get; set; }
    public decimal PriceProduct { get; set; }
    public int QuantityProduct { get; set; }

    public Product()
    {
    }
    public Product(string nameProduct, decimal priceProduct, int quantityProduct)
    {
        NameProduct = nameProduct;
        PriceProduct = priceProduct;
        QuantityProduct = quantityProduct;
    }
}
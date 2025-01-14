using System;
using System.Collections.Generic;

namespace WestWindSystem
{
    public class ProductLine
    {
        #region Ex01a
        public Supplier Supplier { get; private set; }
        
        public ProductLine(Supplier givenSupplier)
        {
            Supplier = givenSupplier;
        }
        #endregion

        #region Ex01b
        public List<Product> Products { get; private set; } = new();
        public int TotalProducts { get { return Products.Count; } }
        //using lambda syntax.
        //public int TotalProducts => Products.Count;

        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(string.Empty,"No product supplied. Product not added.");
            bool found = false;
            foreach(var existingProduct in Products)
                if (product.ProductName.Equals(existingProduct.ProductName))
                    found = true;
            if (found)
                throw new ArgumentException($"The product {product.ProductName} is already part of this product line.");
            Products.Add(product); 
        }
        #endregion
    }
}
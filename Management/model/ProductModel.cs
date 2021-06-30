using System.Collections.Generic;
using Management.entity;

namespace Management.model
{
    public class ProductModel
    {
        private List<Product> _listProduct = new List<Product>();

        public List<Product> FindAll()
        {
            return _listProduct;
        }

        public bool Save(Product product)
        {
            _listProduct.Add(product);
            return true;
        }

        public Product FindbyId(string id)
        {
            for (int i = 0; i < _listProduct.Count; i++)
            {
                var pr = _listProduct[i];
                if (pr.Id == id)
                {
                    return pr;
                }
            }

            return null;
        }

        public bool Update(string id, Product updateProduct)
        {
            Product product = FindbyId(id);
            if (product == null)
            {
                return false;
            }
            product.Name = updateProduct.Name;
            product.Price = updateProduct.Price;
            return true;
        }

        public bool Delete(string id)
        {
            Product product = FindbyId(id);
            if (product == null)
            {
                return false;
            }

            _listProduct.Remove(product);
            return true;
        }
    }
}
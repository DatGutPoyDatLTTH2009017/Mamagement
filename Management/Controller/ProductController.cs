using System;
using System.Collections.Generic;
using Management.entity;
using Management.model;

namespace Management.Controller
{
    public class ProductController
    {
        private List<Product> _listProduct = new List<Product>();
        private ProductModel _productModel = new ProductModel();
        public void TaoMoiProduct()
        {
            Console.WriteLine("Vui lòng nhập thông tin sản phẩm: ");
            var product = new Product();
            Console.WriteLine("Id sản phẩm: ");
            var idProduct = Console.ReadLine();
            product.Id = idProduct;
            Console.WriteLine("Tên sản phẩm: ");
            var tenProduct = Console.ReadLine();
            product.Name = tenProduct;
            Console.WriteLine("Gía sản phẩm: ");
            var giaProduct = double.Parse(Console.ReadLine());
            product.Price = giaProduct;
            bool result = _productModel.Save(product);
            if (result)
            {
                Console.WriteLine("tao moi thanh cong: ");
            }
            else
            {
                Console.WriteLine("tao moi that bai");
            }
        }

        public void HienThiProduct()
        {
            List<Product> listProduct = _productModel.FindAll();
            Console.WriteLine("danh sách sản phẩm vừa nhạp là: ");
            for (int i = 0; i < _listProduct.Count; i++)
            {
                var product1 = _listProduct[i];
                Console.WriteLine($"Id: {product1.Id}, Ten: {product1.Name}, Gia: {product1.Price}");
            }
        }

        public void SuaThongTinProduct()
        {
            Console.WriteLine("Vui lòng nhập id cần sửa");
            string id = Console.ReadLine();
            Product product = _productModel.FindbyId(id);
            if (product != null)
            {
                Console.WriteLine("Ten product");
                var tenProduct = Console.ReadLine();
                product.Name = tenProduct;
                Console.WriteLine("Gia product");
                _productModel.Update(id, product);
                {
                    Console.WriteLine("Không tìm thấy id product");
                }
            }
        }

        public void XoathongtinProduct()
        {
            Console.WriteLine("Vui long nhap id can xoa");
            string id = Console.ReadLine();
            Product product = new Product();
            product = _productModel.FindbyId(id);
            if (product == null)
            {
                Console.WriteLine("Ban co muon Yes/No");
                string luachon = Console.ReadLine();
                if (luachon.ToLower().Equals(id))
                {
                    _productModel.Delete(id);
                    Console.WriteLine("Xoa tahnh cong");
                }
                else
                {
                    Console.WriteLine("Xoa that bai");
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
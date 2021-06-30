using System;
using System.Collections.Generic;

namespace Management
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var product = new Product();
            var listProduct = new List<Product>();
            while (true)
            {
                Console.WriteLine("1. Them ho so san pham: ");
                Console.WriteLine("2. Hien Thi ho so san pham: ");
                Console.WriteLine("3. Xoa ho so san pham: ");
                Console.WriteLine("4. Thoat: ");
                Console.WriteLine("Vui long nhap lua chon tu 1 -> 4");
                var luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        Console.WriteLine("Vui long nhap id");
                        var id = Console.ReadLine();
                        Console.WriteLine("Vui long nhap ten");
                        var ten = Console.ReadLine();
                        Console.WriteLine("Vui long nhap gia");
                        var gia = double.Parse(Console.ReadLine());
                        listProduct.Add(new Product()
                        {
                            Id = id,
                            Name = ten,
                            Price = gia
                        });
                        break;
                    case 2:
                        for (int i = 0; i < listProduct.Count; i++)
                        {
                            Console.WriteLine(listProduct[i].ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Vui long nhap id can xoa");
                        product.Id = Console.ReadLine();
                        for (int i = 0; i < listProduct.Count; i++)
                        {
                            if (product.Id.Equals(listProduct[i].Id))
                            {
                                listProduct.Remove(product);
                                Console.WriteLine("Xoa thanh cong");
                            }
                            else
                            {
                                Console.WriteLine("Id khong ton tai");
                            }
                        }
                        break;
                }

                if (luachon == 4)
                {
                    break;
                }
            }
        }
    }
}
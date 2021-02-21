using System;

namespace Project_Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesMan v1 = new SalesMan();
            v1.name = "Luis";
            v1.age = 35;

            SalesMan v2 = new SalesMan();
            v2.name = "Carlos";
            v2.age = 24;

            SalesMan v3 = new SalesMan();
            v3.name = "Natalia";
            v3.age = 19;

            Product p1 = new Product();
            p1.name = "Papitas";
            p1.price = 2000;

            Product p2 = new Product();
            p2.name = "Gaseosa";
            p2.price = 2500;

            Product p3 = new Product();
            p3.name = "Galletas";
            p3.price = 500;

            Sale sale1 = new Sale();
            sale1.SalesMan = v1;
            sale1.Product = p1;
            sale1.commensts = "venta realizada";

            Sale sale2 = new Sale();
            sale2.SalesMan = v2;
            sale2.Product = p2;
            sale2.commensts = "venta realizada";

            Sale sale3 = new Sale();
            sale3.SalesMan = v3;
            sale3.Product = p3;
            sale3.commensts = "venta realizada";

            float salesTotal = sale1.Product.price + sale2.Product.price + sale3.Product.price;

            Console.WriteLine("las ventas totales son:" + salesTotal);

      

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    //manager, service, gibi bunlar bir operasyon tutuyor demektir.. Ortak code'lar, class ların içine yazılır. Örneğin alışveriş sistemindeki sepete ekleme, sepeti gösterme vs, bu işler
    //metot olarak böyle gruplandırılır.. 
    class SepetManager
    {
        //convention naming convention, bas harfi büyük yazilir
        //
        public void Add(Product product)
        {
            Console.WriteLine(" Ürünler Sepete Eklendi: " + product.ProductName);
        }
        public void Add2(string ProductName, string Description, double Price, int StockCount)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + ProductName);
        }
       


    }
}

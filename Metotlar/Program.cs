using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //tekrar tekrar kullanılabilirliği sağlayan seyler, metotlar.. do not repeat yourself. Best Practices..temiz Kod yazma teknikleri 
            //Sepete ekle, arkasında bir kod var o çalışıyor.. Anasayfaya giriyon, günün ürünü etc, hemen altında sepete ekle..Ürün detayında da sepete ekle var
            //kenarda, onu da sepete ekle diyor. her yerde sepete ekle var :D hepsi aynı..
            //C# java gibi dillerde herşey class lardan oluşur, istisnai config dosyaları hariç.. temel yapılar hep claass içerisinde.

            string productName = "Apple";
            double price = 15;
            string Description = "Amasya Apple";

            string[] meyveler = new string[] { };



            Product product1 = new Product();
            product1.ProductName = "Apple";
            product1.Price = 15;
            product1.Description = "Amasya Apple";

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] Products = new Product[] {product1,product2};
            //type safe  -- C# tip güvenli
            foreach (Product product in Products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("---------------");

            }

            Console.WriteLine("---------------Methods--------------------------------");
            //encapsulation - kapsülleme demek, ayrı ayrı yazacağın düzensiz olacak yapıyı kapsülün içine almak, bir düzene sokmak demek
            //instance - örnek tanımlıyoruz önce.... Tekrar tekrar aynı şeyi kullanabilme imkanı veriyor Metotlar bize.. Yarın bir değişiklik gelirse (kod bloklarında) işimiz kolay olsun diye.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);


            sepetManager.Add2("Armut", "Yerli Armut", 12, 8);
            sepetManager.Add2("Çilek", "Yerli Çilek", 26, 11);
            sepetManager.Add2("Amele boku", "Yersin yemezsin", 55, 22);
            


        }
    }
}

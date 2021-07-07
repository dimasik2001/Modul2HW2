namespace Modul2HW2
{
   public class ProductProvider
    {
        public ProductProvider()
        {
            Products = new Product[21];
            Init();
        }

        public Product[] Products { get; }
        private void Init()
        {
            Products[0] = new Product("Піца Баварська", 70);
            Products[1] = new Product("Піца з тунцем", 70);
            Products[2] = new Product("Піца Сирна", 58);
            Products[3] = new Product("Піца з шинкою та грибами", 60);
            Products[4] = new Product("Піца з куркою та грибами", 64);
            Products[5] = new Product("Піца з яловичиною", 70);
            Products[6] = new Product("Піца з шинкою", 58);
            Products[7] = new Product("Чізбургер", 45);
            Products[8] = new Product("Black chicken бургер", 45);
            Products[9] = new Product("Good Рол", 43);
            Products[10] = new Product("Цезар", 37);
            Products[11] = new Product("Салат з тунцем", 39);
            Products[12] = new Product("Оселедець під шубою", 25);
            Products[13] = new Product("Плов з яловичиною", 43);
            Products[14] = new Product("Спагетті Болоньєзе", 43);
            Products[15] = new Product("Ланч з овочами", 45);
            Products[16] = new Product("Мамині тефтелі", 42);
            Products[17] = new Product("Картопля фрі", 17);
            Products[18] = new Product("Каша вівсяна", 20);
            Products[19] = new Product("Лимонад", 10);
            Products[20] = new Product("Коктейль молочний", 15);
        }
    }
}

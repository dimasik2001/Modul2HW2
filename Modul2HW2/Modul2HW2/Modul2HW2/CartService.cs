namespace Modul2HW2
{
    public class CartService
    {
        private static CartService _instance = new CartService();
        private readonly ConfigService _configService;
        private readonly ProductProvider _productProvider;
        private readonly int _size;
        private int _iterator;
        static CartService()
        {
        }

        private CartService()
        {
            _configService = new ConfigService();
            _productProvider = new ProductProvider();
            _size = _configService.CartConfig.Size;
            ItemsInCart = new Product[_size];
        }

        public Product[] ItemsInCart { get; private set; }
        public static CartService Instance => _instance;

        public void Add(int id)
        {
            if (_iterator < _size)
            {
                ItemsInCart[_iterator++] = _productProvider.Products[id];
            }
        }

        public void RemoveAt(int index)
        {
            for (var i = index; i < _size - 1; i++)
            {
                ItemsInCart[i] = ItemsInCart[i + 1];
            }

            ItemsInCart[_size - 1] = null;
            _iterator--;
        }

        public void Clear()
        {
            ItemsInCart = new Product[_size];
            _iterator = 0;
        }
    }
}

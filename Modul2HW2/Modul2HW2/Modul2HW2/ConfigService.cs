namespace Modul2HW2
{
   public class ConfigService
    {
        private Config _config;
        public ConfigService()
        {
            Init();
        }

        public CartConfig CartConfig => _config.Cart;
        private void Init()
        {
            _config = new Config
            {
                Cart = new CartConfig
                {
                    Size = 10
                }
            };
        }
    }
}

using System;
namespace Modul2HW2
{
   public class Starter
    {
        private readonly CartService _cart;
        private readonly Person _person;
        private OrderMaker _order;
        public Starter()
        {
            _cart = CartService.Instance;
            _person = new Person()
            {
                FirstName = "Ivan",
                LastName = "Petrenko",
                Email = "ivan@gmail.com",
                Telephone = "012-666-1577"
            };
        }

        public void Run()
        {
            var rnd = new Random();
            for (var i = 0; i < 2; i++)
            {
                _cart.Add(rnd.Next(21));
            }

            _order = new OrderMaker()
            {
                Person = _person
            };

            _order.Make();
        }
    }
}

using System;
using System.Text;
namespace Modul2HW2
{
    public class OrderMaker
    {
        private readonly CartService _cart;
        private readonly EmailService _emailService;
        private readonly SMSService _smsService;
        private float _totalPrice;
        public OrderMaker()
        {
            _cart = CartService.Instance;
            _emailService = new EmailService();
            _smsService = new SMSService();
            _totalPrice = CalculateTotal();
            Id = GenerateId();
        }

        public Person Person { get; init; }
        public int Id { get; private init; }
        public void Make()
        {
            _emailService.Email = Person.Email;
            _emailService.OrderNumber = Id;
            _emailService.TotalPrice = _totalPrice;
            _emailService.Send();
            _smsService.Telephone = Person.Telephone;
            _smsService.OrderNumber = Id;
            _smsService.TotalPrice = _totalPrice;
            _smsService.Send();
            _cart.Clear();
        }

        private float CalculateTotal()
        {
            var sum = 0f;
            foreach (var item in _cart.ItemsInCart)
            {
                if (item == null)
                {
                    break;
                }

                sum += item.Price;
            }

            return sum;
        }

        private int GenerateId()
        {
            return int.Parse(DateTime.Now.ToString("MMddhhmmss"));
        }
    }
}

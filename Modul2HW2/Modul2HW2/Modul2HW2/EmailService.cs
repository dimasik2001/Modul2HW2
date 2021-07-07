using System;
namespace Modul2HW2
{
   public class EmailService
    {
        public string Email { get; set; }
        public int OrderNumber { get; set; }
        public float TotalPrice { get; set; }

        public void Send()
        {
            if (Email != string.Empty)
            {
                Console.WriteLine($"Info about order №{OrderNumber} that cost {TotalPrice} was being sent to {Email}");
            }
            else
            {
                Console.WriteLine("Email does not exist");
            }
        }
    }
}

using System;
namespace Modul2HW2
{
    public class SMSService
    {
        public string Telephone { get; set; }
        public int OrderNumber { get; set; }
        public float TotalPrice { get; set; }

        public void Send()
        {
            if (Telephone != string.Empty)
            {
                Console.WriteLine($"Info about order №{OrderNumber} that cost {TotalPrice} was being sent to {Telephone}");
            }
            else
            {
                Console.WriteLine("Telephone does not exist");
            }
        }
    }
}

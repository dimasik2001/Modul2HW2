namespace Modul2HW2
{
    public class Person
    {
        public Person()
        {
            Telephone = string.Empty;
            Email = string.Empty;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
    }
}

namespace MyFuncFile
{
    public class Customer
    {
        // define a customer

        // Data Fields
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public PhoneModel? PhoneNumber { get; set; }
        public int Age { get; set; }
        public DateTime CreateDT { get; } = DateTime.Now;

        //Constructor
        public Customer() { }

        //Functions

        // Method to print all customer data
        public void PrintCustomerData()
        {
            //Capitalize the first letter of the first name and last name
            string capitalizedFirstName = FirstName?.Length > 0 ? char.ToUpper(FirstName[0]) + FirstName.Substring(1) : "";
            string capitalizedLastName = LastName?.Length > 0 ? char.ToUpper(LastName[0]) + LastName.Substring(1) : "";

            Console.WriteLine($"Name: {capitalizedFirstName} {capitalizedLastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone Number: {PhoneNumber.PhoneNumber}");
            Console.WriteLine($"Created At: {CreateDT}\n");
        }
    }

}

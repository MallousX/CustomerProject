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
        public DateTime CreateDT { get; }

        // Constructor
        public Customer(string firstName, string lastName, string email, PhoneModel? phoneNumber, int age)
        {
            FirstName = FormatName(firstName);
            LastName = FormatName(lastName);
            Email = email;
            PhoneNumber = phoneNumber;
            IsCustomerLegal(age); 
            CreateDT = DateTime.Now;
        }


        //Functions
        public string FormatName(string input)
        {
            // Capitalize the first letter of each word
            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public void IsCustomerLegal (int age)
        {
            if (age >= 18)
            {
                // set the age here if valid
                Age = age;
            }
            else
            {
                Console.WriteLine("USer is not at least 18 years of age");
            }
        }

        // Method to print all customer data
        public void PrintCustomerData()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone Number: {PhoneNumber.PhoneNumber}");
            Console.WriteLine($"Created At: {CreateDT}\n");
        }
    }

}

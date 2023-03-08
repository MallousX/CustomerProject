namespace MyFuncFile
{
    public class Customer
    {
        // define a customer

        // Data Fields
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public List<PhoneModel>? PhoneNumbers { get; set; } = new List<PhoneModel>();
        public int Age { get; set; }
        public DateTime CreateDT { get; }

        // Constructor
        public Customer(int id, string firstName, string lastName, string email, int age)
        {
            Id = id;
            FirstName = FormatName(firstName);
            LastName = FormatName(lastName);
            Email = email;
            PhoneNumbers = new List<PhoneModel>();
            IsCustomerLegal(age);
            CreateDT = DateTime.Now;
        }


        //Functions
        public string FormatName(string input)
        {
            // Capitalize the first letter of each word
            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public void IsCustomerLegal(int age)
        {
            if (age >= 18)
            {
                // set the age here if valid
                Age = age;
            }
            else
            {
                Console.WriteLine("User is not at least 18 years of age");
                throw new ArgumentException("User is not at least 18 years of age");
            }
        }

        public void AddPhoneNumber(string phoneNumber, string phoneType)
        {
            {
                // Create a new phone number
                PhoneModel newPhoneNumber = new PhoneModel
                {
                    PhoneNumber = phoneNumber,
                    PhoneType = phoneType
                };

                // Add it to the list
                PhoneNumbers.Add(newPhoneNumber);
            }
        }

        // Method to print all customer data
        public void PrintCustomerData()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
            foreach (PhoneModel number in PhoneNumbers)
            {
                Console.WriteLine($"Phone Number: {number.PhoneNumber}");
            }

            Console.WriteLine($"Created At: {CreateDT}\n");
        }
    }

}
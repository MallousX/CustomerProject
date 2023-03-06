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
            FirstName = firstName; // Use PhoneModel as example
            LastName = lastName; // Use Phone Model as example
            Email = email;
            PhoneNumber = phoneNumber;
            Age = age; 
            CreateDT = DateTime.Now;
        }


        //Functions

        // TODO:
        // Create separate functions to do these things:
        // Change a last name. (Done 3-6-2023 (At Work))
        // Capitalize the first letter of a string (like a name)
        // Validate age is 18 or greater (input int, output bool) (Done? 3-6-2023 (AT WORK))

        public string TitleCase(string input)
        {
            // Do the thing

            // Return the thing
            return "";
        }

        public void ValidateAge(int age)
        {
            // Age check if age >= 18 { set age = age or something}

            // else "Customer has to be at least 18 years of age"

            // Note, this could instead be used to return a bool if age is good/bad
            // Then you'd set the age elsewhere, idk, up to you.
        }

        // Method to print all customer data
        public void PrintCustomerData()
        {
            //Capitalize the first letter of the first name and last name
            string capitalizedFirstName = FirstName?.Length > 0 ? char.ToUpper(FirstName[0]) + FirstName.Substring(1) : "";
            string capitalizedLastName = LastName?.Length > 0 ? char.ToUpper(LastName[0]) + LastName.Substring(1) : "";

            //Console.WriteLine($"Name: {capitalizedFirstName} {capitalizedLastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone Number: {PhoneNumber.PhoneNumber}");
            Console.WriteLine($"Created At: {CreateDT}\n");
        }
    }

}

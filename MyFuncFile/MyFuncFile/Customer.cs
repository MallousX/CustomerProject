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
        public Address? Address { get; set; }
        public List<PhoneModel> PhoneNumbers { get; set; } = new List<PhoneModel>();
        public int Age { get; set; }
        public DateTime CreateDT { get; } = DateTime.Now;

        // Constructor
        public Customer(int id, string firstName, string lastName, string email, int age)
        {
            Id = id;
            FirstName = FormatName(firstName);
            LastName = FormatName(lastName);
            Email = email;
            IsCustomerLegal(age);
        }


        //Functions

        public void AddAddress(string street, string city, string state, string postalCode)
        {
            //create a new address
            Address address = new Address
            {
                Street = street,
                City = city,
                State = state,
                PostalCode = postalCode

            };

            //add it to the customer
            Address = address;
        } 
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

        public void AddPhoneNumber(int id, string phoneNumber, string phoneType)
        {
            {
                // Create a new phone number
                PhoneModel newPhoneNumber = new PhoneModel(id, 1, phoneNumber, phoneType);

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

            // There's an error here if a customer does not have an address.
            // We need to wrap this line inside an if statement
            // that does a null check. if (Address is not null) { }
            Console.WriteLine($"{Address.Street}\n{Address.City} {Address.State}, {Address.PostalCode} ");
                        
            foreach (PhoneModel number in PhoneNumbers)
            {
                Console.WriteLine($"{number.PhoneType} Number: {number.PhoneNumber}");
            }

            Console.WriteLine($"Created At: {CreateDT}\n");
        }

        public void UpdateEmail(string email)
        {
            // set the new email here... yeah that's it
        }

        public void DeletePhoneNumber(int phoneID)
        {
            // Delete the phone number that matches the id
            // go look up a search algorithm yay!
        }
    }

}
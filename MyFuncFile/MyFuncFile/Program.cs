using MyFuncFile;

class Program
{
    static void Main(string[] args)
    {
        //Customer customer = new Customer
        //{
        //    FirstName = "james",
        //    LastName = "reeves",
        //    Age = 38,
        //    Email = "truewinds@gmail.com",
        //    PhoneNumber = new PhoneModel("2816517827")
        //};

        // CRUD = Create, Read, Update, Delete
        // We need to code the rest of this for a Customer object

        // Create Customer
        Customer mallous = new Customer(1, "james", "reeves", "truewinds@gmail.com", 21);

        mallous.AddPhoneNumber(1, "2816517827", "Cell");
        mallous.AddPhoneNumber(2, "5555555555", "Hooker");

        // Commenting this out to cause the code to break
        // homework to fix the beak
        mallous.AddAddress("1010 Bush", "Houston", "Texas", "77090");

        // Update the customer email address

        // Read Customers
        mallous.PrintCustomerData();
        mallous.DeletePhoneNumber(2);
        mallous.PrintCustomerData();
        // Delete Phone Number

        // Read Customer Again

    }
}
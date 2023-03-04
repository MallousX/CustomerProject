using MyFuncFile;

class Program
{
    static void Main(string[] args)
    {
        //var blah = new Funcs();


        //blah.GetformattedDate();

        //Console.WriteLine(blah.GetformattedDate());

        Customer customer = new Customer
        {
            FirstName = "James",
            LastName = "Reeves",
            Age = 38,
            Email = "truewinds@gmail.com",
            PhoneNumber = new PhoneModel("2816517827")
        };

        customer.PrintCustomerData();

        Customer customer2 = new Customer
        {
            FirstName = "Matt",
            LastName = "Dove",
            Age = 37,
            Email = "matt319899@gmail.com",
            PhoneNumber = new PhoneModel("2816517827")
        };
        customer2.PrintCustomerData();
    }
}
﻿using MyFuncFile;

class Program
{
    static void Main(string[] args)
    {
        //var blah = new Funcs();
        //blah.GetformattedDate();
        //Console.WriteLine(blah.GetformattedDate());

        Customer customer = new Customer
        {
            FirstName = "james",
            LastName = "reeves",
            Age = 38,
            Email = "truewinds@gmail.com",
            PhoneNumber = new PhoneModel("2816517827")
        };

        Customer customer2 = new Customer
        {
            FirstName = "matt",
            LastName = "dove",
            Age = 37,
            Email = "matt319899@gmail.com",
            PhoneNumber = new PhoneModel("2816517827")
        };


        // Print Customers
        customer.PrintCustomerData();
        customer2.PrintCustomerData();
    }
}
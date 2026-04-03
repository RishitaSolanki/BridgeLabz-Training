using System;
using System.Collections.Generic;

// class customer
class Customer
{
    public string CustomerName;
    public double Balance;

    //parameterized constructor
    public Customer(string entercustomerName)
    {
        this.CustomerName = entercustomerName;
        this.Balance = 0;
    }


    public void ViewBalance()
    {
        Console.WriteLine(CustomerName + " Balance: " + Balance);
    }
}

// another class name as bank
class Bank
{
    public string BankName;
    public List<Customer> Customers;

    //paramterized constructor
    public Bank(string enterbankName)
    {
        this.BankName = enterbankName;
        this.Customers = new List<Customer>();
    }


    public void OpenYourAccount(Customer customer, double initialAmount)
    {
        customer.Balance = initialAmount;
        Customers.Add(customer);

        Console.WriteLine("Account opened for " + customer.CustomerName +
                          " in " + BankName);
    }
}

// Main class
class Association
{
    //Main Method
    public static void Main(String[] args)
    {

        Bank b = new Bank("Punjab National Bank ");


        Customer c1 = new Customer("Rishita");
        Customer c2 = new Customer("Monty");


        b.OpenYourAccount(c1, 15000);
        b.OpenYourAccount(c2, 8000);


        c1.ViewBalance();
        c2.ViewBalance();
    }
}


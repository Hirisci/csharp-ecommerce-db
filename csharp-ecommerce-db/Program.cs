// See https://aka.ms/new-console-template for more information
using csharp_ecommerce_db;
using csharp_ecommerce_db.Crud;
using csharp_ecommerce_db.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");


foreach(Customer c in CrudCustomer.GetAllCustomer())
{
    Console.WriteLine($"{c.Name} {c.LastName} {c.Email}");
}


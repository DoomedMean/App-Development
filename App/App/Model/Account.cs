using System.Security.Cryptography.X509Certificates;

namespace App.Model;

public class Account
{
    public string Name { get; set; }
    public DateTime DateofBirth { get; set; }
    public string Phone_Number { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
}
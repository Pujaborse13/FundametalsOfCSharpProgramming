using System.ComponentModel.DataAnnotations;
namespace DataAnnotation_DemoProject;

public class Program
{
    static void Main(String[] arg)
    {
        Console.WriteLine("UserInput Validation using data annnotation ");
        
        Console.Write("Name :");
        string  name = Console.ReadLine();
        
        Console.Write("Email :");
        string email = Console.ReadLine();


        Console.Write("Password :");
        string password = Console.ReadLine();


        Console.Write("Confirm Password :");
        string confirmPassword = Console.ReadLine();

        Console.Write("Age :");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Date of Birth (YYYY-MM-DD): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Current Salary: ");
        decimal currentSalary = decimal.Parse(Console.ReadLine());

        Console.Write("About You: ");
        string aboutYou = Console.ReadLine();

        Console.Write("Website (Optional): ");
        string website = Console.ReadLine();

        Console.Write("Phone Number (Optional): ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Credit Card Number (Optional): ");
        string creditCardNumber = Console.ReadLine();



        var user = new UserRegistration
        {
            Name = name,
            Email = email,
            Password = password,
            ConfirmPassword = confirmPassword,
            Age = age,
            DateOfBirth = birthDate,
            CurrentSalary = currentSalary,
            AboutYou = aboutYou,
            Website = website,
            PhoneNumber = phoneNumber,
            CreditCardNumber = creditCardNumber


        };


        var context = new ValidationContext(user);
        var results = new List<ValidationResult>();
        bool IsValid = Validator.TryValidateObject(user, context, results,true);

        if (IsValid)
        {
            Console.WriteLine("User data is valid.Registration successful!");
        }
        else {
            Console.WriteLine("--------Validation Errors ------");
            foreach (var error in results) {
                Console.WriteLine($"--{error.ErrorMessage}");
        }
                
        
     }

    
    
    
    
    }

}
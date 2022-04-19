// See https://aka.ms/new-console-template for more information
using SRPDemo;

//Console.WriteLine("Welcome to my application");

//// The below violates a SRP (Single Responsibility principle)
//// The class should have one responsibility, should only change for 1 reason
//// SRP is a principle , not a requirement


//// Ask for user information
//Person user = new Person();

//Console.WriteLine("What is your first name");
//user.FirstName = Console.ReadLine();


//Console.WriteLine("What is your last name");
//user.LastName = Console.ReadLine();


//// Checks to be sure the first and last names are valid
//if(string.IsNullOrWhiteSpace(user.FirstName))
//{
//    Console.WriteLine("You did not give us a valid first name");
//    Console.ReadLine();
//    return;
//}

//if (string.IsNullOrWhiteSpace(user.LastName))
//{
//    Console.WriteLine("You did not give us a valid last name");
//    Console.ReadLine();
//    return;
//}

//// Create a username for the person
//Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");

//Console.ReadLine();


// Using the SRP principle, for the above code

StandardMessages.WelcomeMessage();
Person user2 = PersonDataCapture.Capture();
 
// Checks to be sure the first and last names are valid
bool isUserValid = PersonValidator.Validate(user2);

if(isUserValid == false)
{
    StandardMessages.EndApplication();
    return;
}

AccountGenerator.CreateAccount(user2);

StandardMessages.EndApplication();

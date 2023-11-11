//GreetingUserAppRefactored
//Author: Justin Spencer
//In this application we will welcome the user to our application, ask them for their first name, and greet them by name.

Console.WriteLine("Welcome to Greeting User Application");
Console.WriteLine("This application was created by Justin Spencer");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine();

Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Hello, {firstName}");
Console.WriteLine();
Console.WriteLine($"Thank you for using the application {firstName}");
Console.ReadLine();


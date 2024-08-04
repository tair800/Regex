using System.Text.RegularExpressions;

string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
string MobilePattern = @"^\d{10}$";

Console.WriteLine("Enter an email address:");
string Email = Console.ReadLine();

Console.WriteLine("Enter a mobile number:");
string Mobile = Console.ReadLine();

bool isEmailValid = Regex.IsMatch(Email, EmailPattern);
bool isMobileValid = Regex.IsMatch(Mobile, MobilePattern);

Console.WriteLine($"Valid email {isEmailValid}");
Console.WriteLine($"Valid num {isMobileValid}");

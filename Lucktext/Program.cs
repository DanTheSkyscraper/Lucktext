string name;
string age;
string distance_time;

Console.WriteLine("What is your name?");
name = Console.ReadLine();

Console.WriteLine("How old are you?");
age = Console.ReadLine();

Console.WriteLine("How long does it take to get to your school if you travel by bus?");
distance_time = Console.ReadLine();

Console.WriteLine($"Thank you for bringing this up {name}. Because of the fact that you are {age} years old and that you have to travel {distance_time} minutes in order to arrive at the school, we have decided to give you permsission to arrive at your classes later than everyone else.");
Console.ReadLine();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string inputString = "1111 2222 3333 4444";
var ints = inputString.Split(' ').Select(Int32.Parse).ToArray();
Console.WriteLine(ints[0] + ints[1]);

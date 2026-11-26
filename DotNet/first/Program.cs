using calc;
using greetings;


Console.WriteLine("Hello, World!");
MyCalc calc = new MyCalc();
int result = calc.Add(5, 3);
Console.WriteLine("Sum: " + result);

Greet greet = new Greet();
Console.WriteLine(greet.Welcome("hariom"));


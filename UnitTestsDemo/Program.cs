// See https://aka.ms/new-console-template for more information


using UnitTestsDemo;

var calculator = new Calculator();
var average = calculator.CalculateAverage(10, 20);
Console.WriteLine(average);

average = calculator.CalculateAverage(-10, -20);
Console.WriteLine(average);

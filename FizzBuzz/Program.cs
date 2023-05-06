using FizzBuzz;
var fizzbuzz = new FizzBuzzStandard();

for (int i = 1;i <= 30; i++)
{
    var converted = fizzbuzz.convert(i);
    Console.WriteLine(converted);
}
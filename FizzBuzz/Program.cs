using FizzBuzz;

//var fizzbuzz = new FizzBuzzStandard();
//var fizzbuzz = new FizzBuzzGousei();
var fizzbuzz = new FizzBuzzUseInterface();

for (int i = 1;i <= 30; i++)
{
    var converted = fizzbuzz.convert(i);
    Console.WriteLine(converted);
}


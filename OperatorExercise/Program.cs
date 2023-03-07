namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            var a = 17;
            var b = 4;

            var sum = a + b;
            Console.WriteLine($"a + b = {sum}");

            var diff = a - b;
            Console.WriteLine($"a - b = {diff}");

            var multi = a * b;
            Console.WriteLine($"a * b = {multi}");

            var quotient = a / b;
            var remainder = a % b;


            if (a == 17 && b == 4)
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            Console.WriteLine();




            //Exercise 2

            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");




            //Thought Experimeent

            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k); //16
        }
    }
}
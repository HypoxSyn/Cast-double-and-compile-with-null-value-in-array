using System.Linq;

double?[] nums = { null, 0, 4, 5, 55, 68, 88, 66, null };
//grab all doubles in nums, sum them up, and assign to sum
double sum = nums.OfType<double>().Sum();

//convert nums that are values to strings
string[] result = nums.Select(i => i.ToString()).ToArray();

Console.WriteLine(sum);


//foreach works with the result array and just write each number as a string
foreach(Object o in result)
{
    Console.WriteLine(o);
}

Console.Read();



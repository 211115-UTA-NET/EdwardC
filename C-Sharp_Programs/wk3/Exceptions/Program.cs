
Console.WriteLine("Exceptions:");

bool loop = false;
Console.WriteLine("Enter a string");

do{
    string? myString = Console.ReadLine();

    try
    {
        Console.WriteLine(myString[0]);
        loop = false;
    }
    catch(IndexOutOfRangeException e)
    {
        Console.WriteLine("Uh oh, you entered no string!");
        Console.WriteLine();
        loop = true;
    }
    finally
    {
        Console.WriteLine("This is the finally block!");
    }
}
while(loop);




// int[] numbers = {0,1,2,3,4,5,6};
// Console.WriteLine("Enter and index between 0 and 6");

// int index = int.Parse(Console.ReadLine());

// try
// {
//     Console.WriteLine(numbers[index]);
// }
// catch(IndexOutOfRangeException e)
// {
//     Console.WriteLine("requested index not in array: " + index);
//     Console.WriteLine($"{e.GetType().Name}: {index} is outside the range of the array" );
// }


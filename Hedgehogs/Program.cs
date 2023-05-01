
while (true)
{
    try
    {
        var hedgehogsService = new Hedgehogs.HedgehogsService();

        var hedgehogs = hedgehogsService.GetRandomHedgehogsPopulation();

        Console.WriteLine($"Number of hedgehogs in order to their color (red, green, blue): {hedgehogs[0]}, {hedgehogs[1]}, {hedgehogs[2]}");

        Console.WriteLine("Enter the number of target color (red - 0, green - 1, blue - 2):");

        var targetColor = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"Number of steps to color to target color: {hedgehogsService.CalulateStepsToSameColor(hedgehogs, targetColor)}");

        Console.WriteLine("End!\n\n\n\n");
    }
    catch(Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
}



//while (true)
//{
//    try
//    {
//        var hedgehogsService = new Hedgehogs.HedgehogsService();

//        var hedgehogs = new int[3];       

//        Console.WriteLine("Enter the number of target color (red - 0, green - 1, blue - 2):");

//        var targetColor = Int32.Parse(Console.ReadLine());

//        Console.WriteLine("Enter the number hedgehogs in order of their color (red, green, blue):");

//        hedgehogs[0] = Int32.Parse(Console.ReadLine());
//        hedgehogs[1] = Int32.Parse(Console.ReadLine());
//        hedgehogs[2] = Int32.Parse(Console.ReadLine());

//        Console.WriteLine($"Number of steps to color of to target color: {hedgehogsService.CalulateStepsToSameColor(hedgehogs, targetColor)}");

//        Console.WriteLine("End!\n\n\n\n");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Error: " + ex.Message);
//    }
//}

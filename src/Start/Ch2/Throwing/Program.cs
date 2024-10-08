﻿// Exercise file for C# Exception and Error Handling by Joe Marini
// Throwing your own exceptions

try {
    var Oven = new MyOven();
    // Set the temp to a valid value
    Oven.SetOvenTemp(300);
    Console.WriteLine($"The oven has been set to {Oven.GetOvenTemp()}");

    // Now use an invalid value
    Oven.SetOvenTemp(600);
    Console.WriteLine($"The oven has been set to {Oven.GetOvenTemp()}");
}
catch (ArgumentOutOfRangeException e) {
    Console.WriteLine($"Exception: {e.Message}");
}

public class MyOven
{
    private int OvenTemp;

    public void SetOvenTemp(int TemperatureF)
    {
        // Make sure that the argument is between 100 and 500
        if(TemperatureF < 100 || TemperatureF > 500){
            throw new ArgumentOutOfRangeException("TemperatureF", TemperatureF, "It must be between 100 and 500.");
        }
        OvenTemp = TemperatureF;
    }

    public int GetOvenTemp()
    {
        return OvenTemp;
    }
}
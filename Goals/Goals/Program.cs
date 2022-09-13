using System;

Console.WriteLine("Enter your goal for today:");
string? newGoal = Console.ReadLine();

bool saveGoal = false;
if (newGoal != null)
{
    newGoal = newGoal.Substring(0, Math.Min(256, newGoal.Length));
    Console.WriteLine($"For {DateTime.Today} your goal is: \n {newGoal} \n Save Changes? (Y/N)");
    string? saveString = Console.ReadLine();
    if (saveString == null)
    {
        Console.WriteLine("Please enter a response:");
        
    }
    else if (saveString.ToLower() == "y" || saveString.ToLower() == "yes")
    {
        
       
    }
}
else
{
    Console.WriteLine("Please enter a goal:");
}

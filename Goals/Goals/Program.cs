Console.WriteLine("Enter your goal for today:");
string? newGoal = Console.ReadLine();

bool saveGoal = false;
if (newGoal != null)
{
    Console.WriteLine($"For {DateTime.Today} your goal is: \n {newGoal} \n Save Changes? (Y/N)");
    string? saveString = Console.ReadLine();
    if (saveString == null)
    {
        Console.WriteLine("Please enter a response:");
        return;
    }
    else if (saveString.ToLower() == "y" || saveString.ToLower() == "yes")
    {
        saveGoal = true;
    }
}
else
{
    Console.WriteLine("Please enter a goal:");
}

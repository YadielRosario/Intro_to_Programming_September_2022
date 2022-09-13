

namespace CSharpSyntaxStuff;

public class CreatingInstancesOfTypes
{
    [Fact]
    public void Doit()
    {
        Assert.True(false);
    }

    [Fact]
    public void DeterminingTypes()
    {
        //Explicit variable declaration
        Int32 x = 12;
        int y = 12;

        string myName = "Yadiel";
        String yourName = "Jeff";
        char middleInitial = 'M';
    }

    [Fact]
    public void ImplicitVariableDeclaration()
    {
        var x = 12;

        var y = "Monkey";

        string yourName;

        yourName = "Paul";

        Assert.Equal("Paul", yourName);

        var bob = new Employee();

        var myPay = new PayCheck();

        var manager = new Manager();

        manager.SaveThis(42);
    }

    [Fact]
    public void NewSchoolCollections()
    {
        // Parametric Polymorphism
        var favoriteNumbers = new List<int>();

        favoriteNumbers.Add(9);
        favoriteNumbers.Add(42);
        favoriteNumbers.Add(20);

        var sumOfFirstTwo = favoriteNumbers[0] + favoriteNumbers[1];
        Assert.Equal(51, sumOfFirstTwo);
    }
}

public class Employee
{

}

public struct PayCheck
{
    public decimal Amount;
    public string Currency;
}

public class Manager
{
    public void SaveThis(Object o)
    {

    }
}



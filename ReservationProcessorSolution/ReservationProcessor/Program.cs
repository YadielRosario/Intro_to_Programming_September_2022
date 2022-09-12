// See https://aka.ms/new-console-template for more information
/*
* We will ask the user for their:
* Email Address
* The ID of the course they'd like to take.
* The ID of the offering of that course they'd like to take.
*
* We will return to them:
* (Happy Path): A message that says their are registered, and a registration ID, and the date of the course.
* (Error): A message that says they cannot enroll for the course, and reason.
*/

using Microsoft.AspNetCore.Mvc;

//Console.WriteLine("Register for a course");
//Console.Write("Enter your email address: ");
//string? email = Console.ReadLine();

//Console.Write("Enter course ID: ");
//string? courseId= Console.ReadLine();

//Console.Write("Enter course offering ID: ");
//string? courseOfferingId= Console.ReadLine();  

//Console.WriteLine($"I see you are {email}, want to take {courseId} of {courseOfferingId}");

////WTCYWYH Write the code you wish you had
//CourseRegistrationManager courseRegistrationManager = new CourseRegistrationManager();

//CourseRegistrationRequest request = new CourseRegistrationRequest(string? Email, string? CourseId, string? CourseOfferingId);

//CourseRegistrationResponse response 
//    = courseRegistrationManager.RegisterforCourse(email, courseId, courseOfferingId);

//if (response.isRegistered)
//{
//    Console.WriteLine("Congratulations! You have been registered!");
//    Console.WriteLine($"Your registration ID is {response.Id}");
//    Console.WriteLine($"The course starts on {response.courseDate:D}");
//}
//else
//{
//    Console.WriteLine("Sorry, you are not registered for the course");
//}

var builder = WebApplication.CreateBuilder();

builder.Services.AddScoped<CourseRegistrationManager>();

var app = builder.Build();

app.MapPost("/registrations", (
    [FromBody] CourseRegistrationRequest request,
    [FromServices] CourseRegistrationManager manager) =>
{
    var response = manager.RegisterForCourse(request);
    if (response.IsRegistered)
    {
        return Results.Ok(response);
    }
    else
    {
        return Results.BadRequest(response);
    }
});


Console.WriteLine("Fixing to run your web application!");
app.Run();
Console.WriteLine("Done running your web application!");
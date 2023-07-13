using Acme.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AcmeAPI.Data;

public static class PrepDb
{
    public static void PrepPopulation(IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            SeedData(serviceScope.ServiceProvider.GetService<AcmeOnlineDbContext>());
        }
    }

    public static List<SerialNumber> GenerateSerialNumbers(int count)
    {
        List<SerialNumber> serialNumbers = new List<SerialNumber>();
        for (int i = 0; i < count; i++)
        {
            serialNumbers.Add(new SerialNumber { Guid = Guid.NewGuid() });
        }

        return serialNumbers;
    }

    public static void SeedData(AcmeOnlineDbContext context)
    {
        if (context.Draws.Any()) return;

        // Seed Users
        var users = new List<User>
        {
            new User { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Password = "password1" },
            new User
            {
                FirstName = "Marie", LastName = "Smith", Email = "marie.smith@example.com", Password = "password2"
            }
        };


        // Seed SerialNumbers
        var serialNumbers = new List<SerialNumber>
        {
            new SerialNumber { Guid = Guid.NewGuid() },
            new SerialNumber { Guid = Guid.NewGuid() }
        };

        // Seed Draws
        var draws = new List<Draw>
        {
            new Draw {  FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", SerialNumber = serialNumbers[0] },
            new Draw {  FirstName = "Marie", LastName = "Smith", Email = "marie.smith@example.com", SerialNumber = serialNumbers[1] }
        };

        // Generate SerialNumbers
        var generatedSerialNumbers = GenerateSerialNumbers(100);
        context.Users.AddRange(users);
        context.SerialNumbers.AddRange(serialNumbers);
        context.SerialNumbers.AddRange(generatedSerialNumbers);
        context.Draws.AddRange(draws);
        context.SaveChanges();
    }
}
using Acme.API.Entities;

namespace Acme.Api.Models;
public class Draw
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public SerialNumber SerialNumber { get; set; }
}


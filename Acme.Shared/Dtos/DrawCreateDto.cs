using Acme.Shared.Dtos;

namespace Acme.API.Entities;
public class DrawCreateDto
{
    public string FirstName { get; set; }
    public string LastName  { get; set; }
    public string Email { get; set; }
    public SerialNumberCreateDto SerialNumber { get; set; }
}


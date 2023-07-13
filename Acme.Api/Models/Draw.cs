using System.ComponentModel.DataAnnotations;
using Acme.API.Entities;

namespace Acme.Api.Models;

public class Draw
{
    public int Id { get; set; }
    [Required] 
    public string FirstName { get; set; }
    [Required] 
    public string LastName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required] 
    public SerialNumber SerialNumber { get; set; }
    
}
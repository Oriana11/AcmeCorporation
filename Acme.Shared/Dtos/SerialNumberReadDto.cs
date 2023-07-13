using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Shared.Dtos;

public class SerialNumberReadDto
{
    public int Id { get; set; }
    public Guid Guid { get; set; }
}
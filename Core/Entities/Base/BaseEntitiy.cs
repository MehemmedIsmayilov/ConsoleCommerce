using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Base;

public class BaseEntitiy
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? Modifietad { get; set; }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common;

public abstract class AuditableBaseEntity
{
    public virtual Guid Id { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime Created { get; set; }
    public string UpdatedBy { get; set; } = string.Empty;
    public DateTime? Updated { get; set; }
}
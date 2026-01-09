using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public class SoftDeletableEntity : BaseEntity
    {
        public Boolean IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; } = null;
    }
}
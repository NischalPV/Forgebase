using System;
using System.ComponentModel.DataAnnotations;
using Forgebase.Masterdata.Core.Interfaces;

namespace Forgebase.Masterdata.Core.Entities.Material
{
    public class Manufacturer: BaseEntity<int>, IAggregateRoot
    {
        [Required]
        public string Name { get; set; }
        public string CreatedBy { get; set; }

        private Manufacturer()
        {
            CreatedDate = DateTime.UtcNow;
        }

        public Manufacturer(DateTime? createdDate = null)
        {
            IsActive = true;
            CreatedDate = createdDate ?? DateTime.UtcNow;
        }
    }
}

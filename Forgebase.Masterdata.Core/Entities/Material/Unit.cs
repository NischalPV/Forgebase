using System;
using System.ComponentModel.DataAnnotations;

namespace Forgebase.Masterdata.Core.Entities.Material
{
    public class Unit: BaseEntity<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Symbol { get; set; }

        public string CreatedBy { get; set; }

        private Unit()
        {
            CreatedDate = DateTime.UtcNow;
        }

        public Unit(DateTime? createdDate = null)
        {
            IsActive = true;
            CreatedDate = createdDate ?? DateTime.UtcNow;
        }
    }
}

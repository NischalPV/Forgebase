using System;
using System.ComponentModel.DataAnnotations;
using Forgebase.Masterdata.Core.Interfaces;

namespace Forgebase.Masterdata.Core.Entities.Material
{
    public class ColorCode: BaseEntity<int>, IAggregateRoot
    {
        [Required]
        public string Code { get; set; }
        public string CreatedBy { get; set; }

        private ColorCode()
        {
            CreatedDate = DateTime.UtcNow;
        }

        public ColorCode(DateTime? createdDate = null)
        {
            IsActive = true;
            CreatedDate = createdDate ?? DateTime.UtcNow;
        }

        public ColorCode(int id, string code, string createdBy, DateTime createdDate, bool isActive)
        {
            Id = id;
            Code = code;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            IsActive = isActive;
        }
    }
}

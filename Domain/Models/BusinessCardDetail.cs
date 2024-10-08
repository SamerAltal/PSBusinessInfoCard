using System;
using System.Collections.Generic;

namespace PSBusinessInfoCard.Domain.Models
{
    public partial class BusinessCardDetail :BaseClass
    {
        public string? Name { get; set; }
        public decimal? Gender { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string? Email { get; set; }
        public decimal? Phone { get; set; }
        public string? Photo { get; set; }
        public string? Address { get; set; }
    }
}

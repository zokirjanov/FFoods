using FFoods.Domain.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Domain.Entities
{
    public class Person : Auditable
    {
        [Required]
        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = String.Empty;

        public string? ImagePath { get; set; }

        public string Description { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        public bool EmailConfirmed { get; set; } = false;

        public string PhoneNumber { get; set; } = String.Empty;

        public bool PhoneNumberConfirmed { get; set; } = false;
    }
}

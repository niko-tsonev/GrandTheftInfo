using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(UserFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [MaxLength(UserMiddleNameMaxLength)]
        public string MiddleName { get; set; } = null!;

        [Required]
        [MaxLength(UserLastNameMaxLength)]
        public string LastName { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}

using FFoods.Domain.Entities.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FFoods.DataAccess.Configurations;
public class SuperAdminConfiguration : IEntityTypeConfiguration<Adminstrator>
{
    public void Configure(EntityTypeBuilder<Adminstrator> builder)
    {
        builder.HasData(new Adminstrator()
        {
            Id = 1,
            FirstName = "System",
            LastName = "Admin",
            Email = "SystemAdmin@gmail.com",
            EmailConfirmed = true,
            IsHead = true,
            PhoneNumber = "+998976260619",
            PhoneNumberConfirmed = true,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Description = "This is super admin",
            ImagePath = "",
            PassportSeria = "AB",
            PassportNumber = 1345411,
            PasswordHash = "$2a$11$wflp2.VTsZmykmMsAydOa.iFXPipGum.T8d9bMa0wDKlfFV9hdbjS",
            Salt = "e036118f-34b1-4955-8cdf-057bce929bcb"
        });
    }
}

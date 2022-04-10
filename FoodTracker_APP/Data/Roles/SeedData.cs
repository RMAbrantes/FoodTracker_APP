namespace FoodTracker_APP.Data.Roles;

public static class SeedData
{
    public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
    {
        await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
        await roleManager.CreateAsync(new IdentityRole(Roles.BasicUser.ToString()));
    }

    public static async Task SeedAdminAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
    {
        //Seed Default User
        var adminUser = new User
        {
            FirstName = "Raquel",
            LastName = "Abrantes",
            UserName = "RMAbrantes",
            Email = "rma@gmail.com",
            EmailConfirmed = true,
            PhoneNumber = "914670789",
            PhoneNumberConfirmed = true
        };

        if (userManager.Users.All(um => um.Id != adminUser.Id))
        {
            var user = await userManager.FindByEmailAsync(adminUser.Email);

            if (user == null)
            {
                await userManager.CreateAsync(adminUser, "Raquel01!");
                await userManager.AddToRoleAsync(adminUser, Roles.Admin.ToString());
            }
        }
    }
}

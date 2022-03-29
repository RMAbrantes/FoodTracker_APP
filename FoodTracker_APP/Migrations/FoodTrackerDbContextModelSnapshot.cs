﻿#nullable disable

namespace FoodTracker_APP.Migrations;

[DbContext(typeof(FoodTrackerDbContext))]
partial class FoodTrackerDbContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "6.0.3")
            .HasAnnotation("Relational:MaxIdentifierLength", 128);

        SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.Action", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.HasKey("Id");

                b.ToTable("Actions");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.Blacklist", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<DateTime>("DateHour")
                    .HasColumnType("datetime2");

                b.Property<int?>("FoodId")
                    .HasColumnType("int");

                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("FoodId");

                b.HasIndex("UserId");

                b.ToTable("Blacklists");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.Category", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.HasKey("Id");

                b.ToTable("Categories");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.FavFood", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<DateTime>("DateHour")
                    .HasColumnType("datetime2");

                b.Property<int?>("FoodId")
                    .HasColumnType("int");

                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("FoodId");

                b.HasIndex("UserId");

                b.ToTable("FavFoods");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.Food", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<int>("CategoryId")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.HasKey("Id");

                b.HasIndex("CategoryId");

                b.ToTable("Foods");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.FoodAction", b =>
            {
                b.Property<int>("ActionId")
                    .HasColumnType("int");

                b.Property<int>("FoodId")
                    .HasColumnType("int");

                b.HasKey("ActionId", "FoodId");

                b.HasIndex("FoodId");

                b.ToTable("FoodActions");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.FoodMeal", b =>
            {
                b.Property<int>("FoodId")
                    .HasColumnType("int");

                b.Property<int>("MealId")
                    .HasColumnType("int");

                b.Property<decimal>("Quantity")
                    .HasColumnType("decimal(5)");

                b.Property<int>("QuantityTypesId")
                    .HasColumnType("int");

                b.HasKey("FoodId", "MealId");

                b.HasIndex("MealId");

                b.HasIndex("QuantityTypesId");

                b.ToTable("FoodMeals");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.Meal", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<DateTime>("EndMeal")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<DateTime>("StartMeal")
                    .HasColumnType("datetime2");

                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("Meals");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.QuantityType", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("Type")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("QuantityTypes");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.User", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("int");

                b.Property<int>("Age")
                    .HasColumnType("int");

                b.Property<DateTime>("BirthDate")
                    .HasColumnType("datetime2");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("bit");

                b.Property<string>("FirstName")
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("Height")
                    .HasColumnType("decimal(5)");

                b.Property<string>("LastName")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("LockoutEnabled")
                    .HasColumnType("bit");

                b.Property<DateTimeOffset?>("LockoutEnd")
                    .HasColumnType("datetimeoffset");

                b.Property<string>("NormalizedEmail")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<string>("NormalizedUserName")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<string>("PasswordHash")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("PhoneNumberConfirmed")
                    .HasColumnType("bit");

                b.Property<string>("SecurityStamp")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("TwoFactorEnabled")
                    .HasColumnType("bit");

                b.Property<string>("UserName")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<decimal>("Weight")
                    .HasColumnType("decimal(5)");

                b.HasKey("Id");

                b.HasIndex("NormalizedEmail")
                    .HasDatabaseName("EmailIndex");

                b.HasIndex("NormalizedUserName")
                    .IsUnique()
                    .HasDatabaseName("UserNameIndex")
                    .HasFilter("[NormalizedUserName] IS NOT NULL");

                b.ToTable("AspNetUsers", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<string>("NormalizedName")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.HasKey("Id");

                b.HasIndex("NormalizedName")
                    .IsUnique()
                    .HasDatabaseName("RoleNameIndex")
                    .HasFilter("[NormalizedName] IS NOT NULL");

                b.ToTable("AspNetRoles", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("ClaimType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("RoleId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.ToTable("AspNetRoleClaims", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("ClaimType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserClaims", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.Property<string>("LoginProvider")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("ProviderKey")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("ProviderDisplayName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("LoginProvider", "ProviderKey");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserLogins", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("RoleId")
                    .HasColumnType("nvarchar(450)");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("AspNetUserRoles", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("LoginProvider")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("Name")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("Value")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("UserId", "LoginProvider", "Name");

                b.ToTable("AspNetUserTokens", (string)null);
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.Blacklist", b =>
            {
                b.HasOne("FoodTracker_APP.Data.Entities.Food", "Food")
                    .WithMany()
                    .HasForeignKey("FoodId");

                b.HasOne("FoodTracker_APP.Data.Entities.User", "User")
                    .WithMany()
                    .HasForeignKey("UserId");

                b.Navigation("Food");

                b.Navigation("User");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.FavFood", b =>
            {
                b.HasOne("FoodTracker_APP.Data.Entities.Food", "Food")
                    .WithMany()
                    .HasForeignKey("FoodId");

                b.HasOne("FoodTracker_APP.Data.Entities.User", "User")
                    .WithMany()
                    .HasForeignKey("UserId");

                b.Navigation("Food");

                b.Navigation("User");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.Food", b =>
            {
                b.HasOne("FoodTracker_APP.Data.Entities.Category", "Category")
                    .WithMany()
                    .HasForeignKey("CategoryId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Category");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.FoodAction", b =>
            {
                b.HasOne("FoodTracker_APP.Data.Entities.Action", "Action")
                    .WithMany()
                    .HasForeignKey("ActionId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FoodTracker_APP.Data.Entities.Food", "Food")
                    .WithMany()
                    .HasForeignKey("FoodId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Action");

                b.Navigation("Food");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.FoodMeal", b =>
            {
                b.HasOne("FoodTracker_APP.Data.Entities.Food", "Foods")
                    .WithMany()
                    .HasForeignKey("FoodId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FoodTracker_APP.Data.Entities.Meal", "Meals")
                    .WithMany()
                    .HasForeignKey("MealId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FoodTracker_APP.Data.Entities.QuantityType", "QuantityTypes")
                    .WithMany()
                    .HasForeignKey("QuantityTypesId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Foods");

                b.Navigation("Meals");

                b.Navigation("QuantityTypes");
            });

        modelBuilder.Entity("FoodTracker_APP.Data.Entities.Meal", b =>
            {
                b.HasOne("FoodTracker_APP.Data.Entities.User", "User")
                    .WithMany()
                    .HasForeignKey("UserId");

                b.Navigation("User");
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.HasOne("FoodTracker_APP.Data.Entities.User", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.HasOne("FoodTracker_APP.Data.Entities.User", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FoodTracker_APP.Data.Entities.User", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.HasOne("FoodTracker_APP.Data.Entities.User", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
    }
}
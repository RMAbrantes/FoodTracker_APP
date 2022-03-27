using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodTracker_APP.Data.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Meals",
                table: "Meals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Foods",
                table: "Foods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodMeals",
                table: "FoodMeals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodActions",
                table: "FoodActions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavFoods",
                table: "FavFoods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blacklists",
                table: "Blacklists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actions",
                table: "Actions");

            migrationBuilder.RenameTable(
                name: "Meals",
                newName: "Meal");

            migrationBuilder.RenameTable(
                name: "Foods",
                newName: "Food");

            migrationBuilder.RenameTable(
                name: "FoodMeals",
                newName: "FoodMeal");

            migrationBuilder.RenameTable(
                name: "FoodActions",
                newName: "FoodAction");

            migrationBuilder.RenameTable(
                name: "FavFoods",
                newName: "FavFood");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "Blacklists",
                newName: "Blacklist");

            migrationBuilder.RenameTable(
                name: "Actions",
                newName: "Action");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meal",
                table: "Meal",
                column: "MealId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Food",
                table: "Food",
                column: "FoodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodMeal",
                table: "FoodMeal",
                column: "FoodMealId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodAction",
                table: "FoodAction",
                column: "FoodActionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavFood",
                table: "FavFood",
                column: "FavFoodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blacklist",
                table: "Blacklist",
                column: "BlacklistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Action",
                table: "Action",
                column: "ActionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Meal",
                table: "Meal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodMeal",
                table: "FoodMeal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodAction",
                table: "FoodAction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Food",
                table: "Food");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavFood",
                table: "FavFood");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blacklist",
                table: "Blacklist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Action",
                table: "Action");

            migrationBuilder.RenameTable(
                name: "Meal",
                newName: "Meals");

            migrationBuilder.RenameTable(
                name: "FoodMeal",
                newName: "FoodMeals");

            migrationBuilder.RenameTable(
                name: "FoodAction",
                newName: "FoodActions");

            migrationBuilder.RenameTable(
                name: "Food",
                newName: "Foods");

            migrationBuilder.RenameTable(
                name: "FavFood",
                newName: "FavFoods");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "Blacklist",
                newName: "Blacklists");

            migrationBuilder.RenameTable(
                name: "Action",
                newName: "Actions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meals",
                table: "Meals",
                column: "MealId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodMeals",
                table: "FoodMeals",
                column: "FoodMealId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodActions",
                table: "FoodActions",
                column: "FoodActionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Foods",
                table: "Foods",
                column: "FoodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavFoods",
                table: "FavFoods",
                column: "FavFoodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blacklists",
                table: "Blacklists",
                column: "BlacklistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actions",
                table: "Actions",
                column: "ActionId");
        }
    }
}

# Relatório do Projecto:

Criação das tabelas:
1. Action → Id; Name 
2. Blacklist → Id; UserId; FoodId; DateTime(DateHour)
3. Category → Id; CategoryName
4. FavFood → Id; UserId; FoodId; DateTime(DateHour)
5. Food → Id; CategoryId; FoodName; ActionId
6. FoodAction → Id; FoodId;
7. FoodMeal → Id; FoodId; Quantity;
8. Meal → Id; FoodMealId; MealName; DateTime Start Meal, DateTime EndMeal
9. Quantity Type → Id; Type
10. User → Id; FirstName; LastName; DOB; Weight; Height; Age

Refs and Helpers:
https://codewithmukesh.com/blog/user-management-in-aspnet-core-mvc/
https://github.com/MarkPflug/Sylvan.AspNetCore/blob/main/docs/CsvFormatter.md
https://stackoverflow.com/questions/70677817/uploading-and-handling-csv-file-to-an-asp-net-core-web-api
https://www.appsloveworld.com/insert-delete-update-records-in-csv-file-asp-net/
https://www.codegrepper.com/code-examples/csharp/how+to+read+a+csv+file+in+c%23
https://www.codeproject.com/Articles/685310/Simple-and-Fast-CSV-Library-in-Csharp
https://www.findandsolve.com/articles/cannot-create-dbset-identity-role-because-this-type-is-not-included-in-model-for
https://stackoverflow.com/questions/54717069/cannot-create-a-dbset-for-identityuser-because-this-type-is-not-included-in-th
https://chsakell.com/2018/04/28/asp-net-core-identity-series-getting-started/
https://www.youtube.com/watch?v=E8JaZdtXTBQ

CsvFile:
→ Create CsvFile Importer to load info


Adding Custom Fields to Identity User:
→ add certain user-specific properties like First Name, Last Name, etc.
→ create a new class Models/User.cs and inherit the Identity User.
→ Areas/Identity/Pages/Account/Manage/Index.cshtml.cs
→ OnPostAsync method, add info to update the newly entered FirstName or LastName, etc.
→ add the HTML definition of the form fields, in the Index.cshtml
→ allow users to log in with both the username and the email id. 
→ Areas/Identity/Pages/Account/Login.cs

User Roles – Overview:
→ User Roles to help define the level of permission for each user
→ Roles + SeedData class implementadas mas não a ser utilizadas
(Tentativa de colocar Roles e limitar o que o Admin/User conseguem ver mas não terminei;
Apenas consegui que o Menu fosse acessado quando se faz Login.)

CRUD:
1. Actions (não terminada → ideia era o Admin poder criar, editar, apagar mais actions)
2. Categories (não terminada → ideia era o Admin poder criar, editar, apagar mais categories)
3. Foods (não terminada → User consegue adicionar alimentos mas não tem acesso à Categoria/Acção correspondente)
4. Blacklist Foods (User pode adicionar alimentos à sua lista e este regista data/hora de criação)
5. FavFoods (User pode adicionar alimentos à sua lista e este regista data/hora de criação)
6. Meals (não terminada → User consegue adicionar refeições e por data/hora e alimentos,
mas apenas nos Details é possível ver o que foi adicionado e não estão associadas as quantidadas)

Dashboard: 
1. Total Users Nr 
2. Total Meals
3. Top 10 Foods
4. Top 5 Active Users






# FoodOrderingApp
The FoodOrderingApp is a modern App written in C# using Windows Form. The app provides a much easier way for customers to order food and get it after the order will be ready to go. 
The app can be modified to work for order delivery as well.

The app regularly updates its menu and also adds a holiday discounts. You can see the latest updates and discount days in [Food App](coming_sooon).

## Features
 - You can place an order yourself
 - You can track your order by checking your name on the waiting list.
 - You will receive a message when your order is ready for pickup.
 - Ability to place an order with more than 2 items
 - Ability to update or delete your order if necessary

   ## Features in progress
   - Ability to leave reviews for any food and drinks you like
   - Opportunity to get a 5% discount on your birthday.
   - Ability to see details and calorie content of food or drinks
   - Opportunity to order additional items, such as: ranch, ketchup, sugarl, milk

## Getting started
1. Your computer must be running Windows 10 or newer
2. Install the latest version of [Visual Studio](https://developer.microsoft.com/en-us/windows/downloads/)
3. Open Visual Studio Setup
4. Install the `ASP.NET`, `Web Development`, and `Data storage and processing` workload
5. Get the URL: ``https://github.com/VladProgrammer08/FoodOrderingApp.git``
6. Open Visual Studio, chose Clone a repository, type the URL and click Clone
7. After the code is cloned, go to: Tools -> NuGet Package Manager -> Package Manager Console
8. After the console is oppened, run these commands: `Add-Migration Initial` (close the form if it's poped up)
9. After it says Build successfully, run `Update-Database` (close the form if it's poped up)
10. To Run and Open App, on the menu bar, choose Debug -> Start without debugging

## Resources
 - [Windows Forms App](https://learn.microsoft.com/en-us/visualstudio/ide/create-csharp-winform-visual-studio?view=vs-2022)
 - [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/get-started/winforms)


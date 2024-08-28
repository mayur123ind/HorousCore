# HorousCore
# Introduction
A simple web application and show table data of HorusCore Inventory.

- In this Application I used SOLID Principle.

# SOLID Principles I Used:
-  Single Responsibility Principle : in this application InventoryController and    InventoryService have two classes that has distinct responsibilities.
    Why : making it easier to maintain and test.

- Open/Closed Principle: The design is open for extension but closed for modification. 
    Why :If I want to add new methods like filtering inventory items, i can extend the InventoryService without changing existing functionality.

- Dependency Inversion Principle: This helps in decoupling the creation of objects from their usage. In this project the InventoryService is injected into the InventoryController via the constructor, promoting loose coupling and making the code more testable and maintainable.

# Run The Project: Visual Studio

- Open the project using Visual Studio
- Change the connection string (appsettings.json) to target your MS SQL Server
- After connection string perform migrtaion to make a connection wwith database
- Run the project by clicking green play button on your Visual Studio toolbar
note: The project will automatically create the Database if the database not already exists.

# Screenshots

![ss1](https://github.com/user-attachments/assets/379823b4-f96a-44de-b02d-db50b138ae5f)
![ss2](https://github.com/user-attachments/assets/6f7b92c3-7533-4fae-9096-1a0e5e7440c2)

Project Documentation: C# Inventory Manager
This document provides an overview of the C# Inventory Manager project, including its purpose, features, and instructions for use.

1. Introduction
The C# Inventory Manager is a console-based application designed to help small businesses track and manage their inventory. It provides a simple and efficient way to add, remove, update, and view inventory items.

2. Features
Add Inventory: Add new items to the inventory, including name, quantity, and price.

View Inventory: Display a list of all items currently in the inventory, showing their details.

Update Inventory: Modify the quantity or price of an existing item.

Remove Inventory: Delete an item from the inventory.

Data Persistence: Save inventory data to a file (JSON) to preserve data between program executions.

Error Handling: Basic input validation and error handling to prevent invalid data.

3. Technical Details
Language: C#

Data Storage: JSON file (inventory.json)

Project Type: Console Application

Key Classes:

InventoryItem: Represents an item in the inventory.

InventoryManager: Manages the collection of inventory items and provides the main functionalities.

Program: Contains the Main method and handles user interaction.

4. Class Details
4.1 InventoryItem Class
Represents an item in the inventory.

Properties:

Name (string): The name of the item.

Quantity (int): The quantity of the item in stock.

Price (decimal): The price of the item.

Methods:

ToString(): Returns a string representation of the inventory item.

4.2 InventoryManager Class
Manages the collection of inventory items.

Fields:

inventory (List<InventoryItem>): A list to store the inventory items.

Methods:

AddItem(string name, int quantity, decimal price): Adds a new item to the inventory.

ViewInventory(): Displays all items in the inventory.

UpdateItem(string name, int? quantity, decimal? price): Updates the quantity and/or price of an existing item.

RemoveItem(string name): Removes an item from the inventory.

SaveInventory(): Saves the inventory data to a JSON file (inventory.json).

LoadInventory(): Loads the inventory data from a JSON file (inventory.json).

4.3 Program Class
Contains the Main method, which is the entry point of the application.

Methods:

Main(string[] args):  Handles the main program logic, including displaying the menu, getting user input, and calling the appropriate methods in the InventoryManager class.

5. Instructions for Use
Prerequisites:

.NET Runtime (required to run the application)

A text editor or IDE (e.g., Visual Studio, VS Code)

Running the Application:

Download: Download the source code.

Build (If necessary): If you downloaded the source code, use Visual Studio or the dotnet build command to build the project. If you downloaded a pre-built executable, skip to the next step.

Run: Open a terminal or command prompt, navigate to the directory containing the executable (.exe file), and run the program (e.g., InventoryManager.exe).

Use the Menu: The application will display a menu with the following options:

1. Add Item

2. View Inventory

3. Update Item

4. Remove Item

5. Exit

Enter your choice: Enter the number corresponding to the action you want to perform and press Enter.

Follow the prompts: The application will prompt you for the necessary information (e.g., item name, quantity, price).

Repeat: Continue using the menu to manage your inventory.

Exit: Choose the "Exit" option to quit the application. The inventory data will be saved to inventory.json before the program terminates.

6. Data Storage
The inventory data is stored in a JSON file named inventory.json in the same directory as the executable file.  The file is automatically created if it doesn't exist.  The data is saved whenever the user exits the program.

7. Error Handling
The application includes basic error handling:

Invalid input: If you enter invalid input (e.g., non-numeric values for quantity or price), the application will display an error message and prompt you to enter the correct information.

Item not found: If you try to update or remove an item that doesn't exist, the application will display an error message.

8. Future Enhancements
Implement a more user-friendly interface (e.g., a graphical user interface).

Add more advanced features, such as:

Search and filtering

Report generation

Database integration

User authentication

Item categories

Supplier management

Order management

Improve error handling and input validation.

Add unit tests.
# Inventory Management System

## Project Goal:

Creation of a console-based application where users can comprehensively track and manage their inventory. Allows users to add, amend, and remove inventory items, including details such as name, brand, description, quantity, price, and type. Provides users with a way to effectively manage and maintain accurate records of their inventory.

## Major Features:

Here's what the app can currently do:

Feature 1: Add a new item to the inventory, including name, brand, description, quantity, price, and type.
Feature 2: Update the details (name, brand, description, quantity, price, or type) of an existing inventory item.
Feature 3: View all inventory items with their complete details, presented in a paginated format for easy browsing.
Feature 4: View a specific inventory item by searching for its ID, name, brand, or type.
Feature 5: Remove a specific product from the inventory using its unique ID.
Feature 6: Initialize the inventory with a set of sample items at the user's request upon starting the application.

## Breakdown of Features into Tasks:

Here's a detailed breakdown of the steps for each main feature:

**Feature 1: Adding a new inventory item**
Task 1.1: Ask the user for the item's name.
Task 1.2: Ask for the item's brand.
Task 1.3: Ask for the item's description.
Task 1.4: Ask for the initial stock quantity.
Task 1.5: Ask for the item's price.
Task 1.6: Ask for the item's type.
Task 1.7: Ensure the quantity and price are valid numbers (greater than zero).
Task 1.8: Create a way to store this new item's information.
Task 1.9: Actually save the new item to the inventory.
Task 1.10: Tell the user the item has been added.

**Feature 2: Updating an inventory item**
Task 2.1: Ask the user for the ID of the item they want to update.
Task 2.2: Find that item's information in the inventory.
Task 2.3: If found, present a menu of options to update: name, brand, description, quantity, price, or type (or all details at once).
Task 2.4: For each selected option, ask for the new value.
Task 2.5: Validate the new quantity and price if they are being updated.
Task 2.6: Update the corresponding information for that item.
Task 2.7: Save the updated information.
Task 2.8: Tell the user the item has been updated and display the new details.
Task 2.9: Handle the case where the provided ID does not match any item in the inventory.

**Feature 3: Viewing all inventory items**
Task 3.1: Retrieve all the inventory items from storage.
Task 3.2: Display the name, brand, description, quantity, price, and type of each item.
Task 3.3: Implement pagination to show a limited number of items per page (e.g., 5).
Task 3.4: Allow the user to navigate to the next page ('N'), previous page ('P'), or exit the viewing mode ('X').
Task 3.5: Display the current page number and the total number of pages.
Task 3.6: Inform the user if the inventory is empty.

**Feature 4: Viewing a specific inventory item**
Task 4.1: Ask the user how they want to search (by ID, Name, Brand, or Type).
Task 4.2: Based on the chosen option, ask the user for the search term.
Task 4.3: Search the inventory for items matching the criteria (case-insensitive for Name, Brand, and Type).
Task 4.4: If a match is found, display the complete details of the item(s).
Task 4.5: If no matching item is found, inform the user.

**Feature 5: Removing an inventory item**
Task 5.1: Ask the user for the ID of the item they want to remove.
Task 5.2: Find the item with the given ID in the inventory.
Task 5.3: If found, display the item's details and ask for confirmation before deleting.
Task 5.4: If the user confirms, remove the item from the inventory.
Task 5.5: Tell the user if the item has been successfully removed.
Task 5.6: Handle the case where the provided ID does not match any item in the inventory.

**Feature 6: Initializing with sample inventory**
Task 6.1: Upon application start, ask the user if they want to create a sample inventory (Y/N).
Task 6.2: If the user chooses 'Y', populate the inventory with a predefined set of sample `InventoryItem` objects.
Task 6.3: Inform the user whether the sample inventory was initialized or skipped.

## How the code is organised (Modules):

The codebase is structured into the following modules:

* **`Program.cs`**: This serves as the main entry point of the application. It handles the main program loop, displays the main menu, and orchestrates the calls to other modules based on user input. It also initializes the inventory dictionary and handles the initial sample inventory creation.
* **`InventoryManager.cs`**: This class contains the core business logic for managing inventory items. It includes static methods for creating new items (`CreateInventoryItem`), updating existing items (`UpdateInventoryItem`), displaying all items with pagination (`ShowInventoryItems`), displaying specific items by various criteria (`ShowSpecificItemById`, `ShowSpecificItemByName`, `ShowSpecificItemByBrand`, `ShowSpecificItemByType`), and deleting items (`DeleteInventoryItem`).
* **`InventoryItem.cs`**: This class defines the structure and behavior of an individual inventory item. It implements the `IInventoryItem` interface and includes properties for `_itemName`, `_itemBrand`, `_itemDescription`, `_quantity`, `_price`, and `_itemType`, as well as methods to update these properties and display the item's details (`DisplayItemDetails`).
* **`IInventoryItem.cs`**: This interface defines a contract for inventory item classes, specifying the essential properties (`_itemName`, `_itemBrand`, `_itemDescription`, `_quantity`, `_price`, `_itemType`) and methods (`UpdateItemName`, `UpdateItemDescription`, `UpdateItemQuantity`, `UpdateItemPrice`, `DisplayItemDetails`) that any inventory item implementation must adhere to.
* **`PopulateInitialInventoryClass.cs`**: This class contains a static method (`PopulateInventoryItems`) responsible for creating and adding a predefined set of sample `InventoryItem` objects to the inventory dictionary when the user chooses to initialize a sample inventory.
* **`Parsing.cs`**: This utility class provides a static method (`ParseInputToInteger`) to safely parse string inputs into integer values, returning a specific value (e.g., -1) to indicate parsing failure.

## Beginner Notes on C# Stuff:

* **Input:** `Console.ReadLine()` is used to get text input from the user in the console.
* **Output:** `Console.WriteLine()` is used to display text and information to the user on the console.
* **Data Storage:** The inventory items are currently stored in a `Dictionary<int, InventoryItem>` object within the `Program` class. The `int` key serves as a unique identifier for each `InventoryItem` object. The `InventoryItem` class holds the details of each product. This storage is in-memory only and will not persist after the application closes.
* **Interfaces:** The `IInventoryItem` interface defines a blueprint for inventory items, ensuring that any class implementing it has specific properties and methods. This promotes consistency and allows for potential future扩展 with different types of inventory items.
* **Logic and Control Flow:**
    * `if`/`else` statements are used for decision-making based on user input and conditions.
    * `switch` statements handle different options selected from the main menu.
    * `foreach` loops iterate over collections of inventory items (e.g., when displaying all items).
    * `while` loops are used for the main application loop and for handling pagination when viewing inventory.
    * Basic data types like `string`, `decimal`, and `int` are used to store item attributes.
    * `try-catch` blocks are used for basic error handling, such as when parsing user input to numbers.
* **Namespaces and `using` directives:** The code is organized within the `InventoryManagementSystem` namespace. The `using` directive is used to import namespaces (like `System.Collections.Generic` for using Dictionaries) to avoid writing fully qualified names.
* **Static Methods:** The `InventoryManager`, `PopulateInitialInventoryClass`, and `Parsing` classes primarily use static methods, meaning these methods can be called directly on the class itself without needing to create an instance of the class.

## Future Ideas (Maybe later!):

Things I could add to make it better:

* Saving the inventory data to a persistent storage mechanism (like a text file, CSV file, or a database).
* Implementing more robust and potentially automated unique ID generation for inventory items.
* Adding more advanced search functionalities, such as searching by partial names, descriptions, or price ranges.
* Generating reports on the inventory, such as low stock levels, total inventory value, or item popularity.
* Implementing user authentication and authorization if multiple users were to interact with the system.
* Developing a more user-friendly graphical user interface (GUI) instead of a console application.
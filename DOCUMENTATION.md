# Project Documentation: C# Inventory Manager

This document provides an overview of the C# Inventory Manager project, including its purpose, features, and instructions for use.

## 1. Introduction

The C# Inventory Manager is a console-based application designed to help small businesses track and manage their inventory. It provides a simple and efficient way to add, remove, update, and view inventory items. It was designed and made to develop my C# and .NET skills and provide something to showcase in my portfolio.

## 2. Features

* **Add Inventory:** Add new items to the inventory, including name, quantity, and price.
* **View Inventory:** Display a list of all items currently in the inventory, showing their details.
* **Update Inventory:** Modify the quantity or price of an existing item.
* **Remove Inventory:** Delete an item from the inventory.
* **Data Persistence:** The application does not currently save data between sessions. Inventory data is lost when the application is closed.
* **Error Handling:** Basic input validation and error handling to prevent invalid data.
* **Sample Data:** The application can be initialized with a set of sample inventory items.

## 3. Technical Details

* **Language:** C#
* **Data Storage:** The application uses a `Dictionary<int, InventoryItem>` in the `Program` class to store inventory data in memory. Data is not persisted between sessions.
* **Project Type:** Console Application
* **Key Classes:**
    * `Program`: Contains the `Main` method and handles user interaction and the main inventory storage.
    * `InventoryItem`: Represents an item in the inventory.
    * `InventoryManager`: Manages the collection of inventory items and provides the main functionalities.
    * `PopulateInitialInventoryClass`: Contains the method to populate the inventory with sample data.
    * `Parsing`: Contains the method to parse user input strings to integers.
    * `IInventoryItem`: Defines the structure and methods for inventory items.

## 4. Class Details

### 4.1 InventoryItem Class

Represents an item in the inventory.

**Properties:**

* `_itemName` (string): The name of the item.
* `_itemBrand` (string): The brand of the item.
* `_itemDescription` (string): The description of the item.
* `_quantity` (int): The quantity of the item in stock.
* `_price` (decimal): The price of the item.
* `_itemType` (string): The type of item.

**Methods:**

* `InventoryItem(string itemName, string itemBrand, string itemDescription, int quantity, decimal price, string itemType)`: Constructor for creating an `InventoryItem` object.
* `UpdateItemName(string newItemName)`: Updates the name of the item.
* `UpdateItemDescription(string newItemDescription)`: Updates the description of the item.
* `UpdateItemQuantity(int newQuantity)`: Updates the quantity of the item.
* `UpdateItemPrice(decimal newPrice)`: Updates the price of the item.
* `UpdateItemType(string newItemType)`: Updates the type of the item.
* `DisplayItemDetails()`: Displays the details of an inventory item.

### 4.2 InventoryManager Class

Manages the collection of inventory items.

**Methods:**

* `CreateInventoryItem()`: Creates a new inventory item based on user input.
* `ShowInventoryItems(Dictionary<int, InventoryItem> inventoryItems)`: Displays all items in the inventory, with pagination.
* `UpdateInventoryItem(Dictionary<int, InventoryItem> inventoryItems, int id)`: Updates the details of an existing item.
* `DeleteInventoryItem(Dictionary<int, InventoryItems> inventoryItems, int id)`: Removes an item from the inventory.
* `ShowSpecificItemById(Dictionary<int, InventoryItem> inventoryItems, int id)`: Displays a specific item by its ID.
* `ShowSpecificItemByName(Dictionary<int, InventoryItem> inventoryItems, string name)`: Displays items with a specific name.
* `ShowSpecificItemByBrand(Dictionary<int, InventoryItem> inventoryItems, string brand)`: Displays items with a specific brand.
* `ShowSpecificItemByType(Dictionary<int, InventoryItem> inventoryItems, string type)`: Displays items of a specific type.

### 4.3 Program Class

Contains the `Main` method, which is the entry point of the application.

**Fields:**

* `inventoryItems` (`Dictionary<int, InventoryItem>`): A dictionary to store the inventory items, using the an integer ID as the key.

**Methods:**

* `Main(string[] args)`: Handles the main program logic, including displaying the menu, getting user input, and calling the appropriate methods in the `InventoryManager` class.

### 4.4 PopulateInitialInventoryClass

Populates the inventory with a set of initial sample items.

**Methods:**

* `PopulateInventoryItems(Dictionary<int, InventoryItem> inventoryItems)`: Adds a predefined set of `InventoryItem` objects to the `inventoryItems` dictionary.

### 4.5 Parsing Class

Provides utility for parsing string inputs.

**Methods:**

* `ParseInputToInteger(string input)`: Attempts to convert a string to an integer, returning the integer if successful, and -1 if not.

### 4.6 IInventoryItem Interface

Defines the structure and methods for inventory items.

**Properties:**

* `_itemName` (string): The name of the item.
* `_itemBrand` (string): The brand of the item.
* `_itemDescription` (string): The description of the item.
* `_quantity` (int): The quantity of the item in stock.
* `_price` (decimal): The price of the item.
* `_itemType` (string): The type of item.

**Methods:**

* `UpdateItemName(string newItemName)`: Updates the name of the item.
* `UpdateItemDescription(string newItemDescription)`: Updates the description of the item.
* `UpdateItemQuantity(int newQuantity)`: Updates the quantity of the item.
* `UpdateItemPrice(decimal newPrice)`: Updates the price of the item.
* `UpdateItemType(string newItemType)`: Updates the type of the item.
* `DisplayItemDetails()`: Displays the details of an inventory item.

## 5. Instructions for Use

**Prerequisites:**

* .NET Runtime (required to run the application)
* A text editor or IDE (e.g., Visual Studio, VS Code)

**Running the Application:**

1.  **Download:** Download the source code.
2.  **Build (If necessary):** If you downloaded the source code, use Visual Studio or the `dotnet build` command to build the project. If you downloaded a pre-built executable, skip to the next step.
3.  **Run:** Open a terminal or command prompt, navigate to the directory containing the executable (`.exe` file), and run the program (e.g., `InventoryManager.exe`).
4.  **Initialize Sample Inventory (Optional):** When the application starts, you will be prompted to create a sample inventory. Entering `'Y'` will populate the inventory with a predefined set of items. Entering `'N'` will start with an empty inventory.
5.  **Use the Menu:** The application will display a menu with the following options:
    ```
    1. Create Inventory Item
    2. Update Inventory Item
    3. View All Inventory Items
    4. View Specific Inventory Item
    5. Delete Inventory Item
    6. Exit
    Enter your choice:
    ```
    Enter the number corresponding to the action you want to perform and press Enter.
6.  **Follow the prompts:** The application will prompt you for the necessary information (e.g., item name, quantity, price).
7.  **Repeat:** Continue using the menu to manage your inventory.
8.  **Exit:** Choose the "Exit" option to quit the application. The inventory data will be lost when the program terminates.

## 6. Data Storage

Inventory data is stored in memory using a `Dictionary<int, InventoryItem>`. Data is not persisted between program executions.

## 7. Error Handling

The application includes basic error handling:

* **Invalid input:** If you enter invalid input (e.g., non-numeric values for quantity or price), the application will display an error message and prompt you to enter the correct information.
* **Item not found:** If you try to update or remove an item that doesn't exist, the application will display an error message.
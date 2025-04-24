//Program.cs
using System;

namespace InventoryManagementSystem
{
    // This is the main entry point for the Inventory Management System application.
    // It initializes the system and starts the user interface.
    // The application allows users to manage inventory items, including adding, removing, and viewing items.
    // It also provides functionality for searching and filtering items based on various criteria.

    class Program
    {
        // This is the main method that runs when the application starts.
        
        public static Dictionary<int, InventoryItem> inventoryItems = new Dictionary<int, InventoryItem>();

        static void Main(string[] args)
        {
            Console.Clear();
            // Clear the console for a clean terminal after compilation and startup

            Console.WriteLine("Would you like to create a sample inventory? Input (Y/N) and press enter.");
            // Prompt the user to choose whether to create a sample inventory
            Console.WriteLine("This will populate the inventory with sample items.");
            Console.WriteLine("");            
            Console.WriteLine("Y to create a sample inventory, N to skip.");
            Console.WriteLine("");
            Console.WriteLine("Example:iPhone 14, Apple, Latest smartphone with advanced features and a powerful camera., 20, 799.99m, Smartphone ");
            Console.WriteLine("");
            Console.Write("Enter your choice (Y/N): ");
            // Display a message indicating that sample items will be added to the inventory
            
            string initializeSampleInventory = Console.ReadLine();
            Console.WriteLine("");

            if (initializeSampleInventory?.ToUpper() == "Y" || initializeSampleInventory?.ToUpper() == "YES")
            {
                PopulateInitialInventoryClass.PopulateInventoryItems(inventoryItems);
                Console.Clear();
                // Call the method to populate the inventory with sample items
            } 
            else if (initializeSampleInventory?.ToUpper() == "N" || initializeSampleInventory?.ToUpper() == "NO")
            {
                Console.Clear();
                Console.WriteLine("No sample inventory initialized.");
                Console.WriteLine("");
                // Display a message indicating that no sample inventory was initialized
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
                Console.WriteLine("");
                // Display an error message if the user enters an invalid input
            }

            Console.WriteLine("Welcome to the Inventory Management System!");
            Console.WriteLine("");
            // Display a welcome message to the user to indicate the start of the application

            bool running = true;
            while (running)
                {
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Create Inventory Item");
                    Console.WriteLine("2. Update Inventory Item");
                    Console.WriteLine("3. View All Inventory Items");
                    Console.WriteLine("4. View Specific Inventory Item");
                    Console.WriteLine("5. Delete Inventory Item");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("");
                    // Display a menu of options for the user to choose from
                    Console.Write("Enter your choice (1-6): ");
                    // Prompt the user to enter their choice from the menu
                    string option = Console.ReadLine();
                    Console.WriteLine("");
                    Console.Clear();
                    // Read the user's input to determine which action to perform

                    int parsedOption;
                    // Declare a variable to store the parsed option
                    

                    if (string.IsNullOrEmpty(option))
                    {
                        Console.WriteLine($"Invalid input: null or empty");
                        Console.WriteLine("Please enter a valid option.");
                        Console.WriteLine("");
                        // Display an error message if the user enters an empty input
                    }
                    else if (int.TryParse(option, out parsedOption) && parsedOption < 1 || parsedOption > 6){
                        Console.WriteLine($"Invalid input: {option}");
                        Console.WriteLine("Please enter a number between 1 and 4.");
                        Console.WriteLine("");
                        // Display an error message if the user enters a string input
                    }
                    else if (int.TryParse(option, out parsedOption) && parsedOption >= 0 || parsedOption <= 4)
                    // This loop continues until the user enters a valid option (1-4)
                    // It ensures that the program keeps running until a valid input is provided
                    // The loop will break if the user enters a valid option
                    // The loop will also break if the user enters an invalid option
                    {
                        switch (parsedOption)
                        {
                            case 1:
                                InventoryItem item = InventoryManager.CreateInventoryItem();
                                // Create a new InventoryItem object using the InventoryManager class
                                // The using statement ensures that the object is disposed of properly after use

                                if (item != null)
                                {
                                inventoryItems.Add(inventoryItems.Count + 1, item);
                                // Add the created inventory item to the inventoryItems dictionary
                                // The key is the current count of items plus one to ensure unique keys

                                item.DisplayItemDetails();
                                // Display the details of the created inventory item

                                Console.WriteLine($"Items in Inventory: {inventoryItems.Count}");
                                // Display the total number of items in the inventory
                                Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine("Failed to create inventory item.");
                                    if (item._itemName == null)
                                    {
                                        Console.WriteLine("Item name cannot be null.");
                                    } else if (item._itemDescription == null)
                                    {
                                        Console.WriteLine("Item description cannot be null.");
                                    } else if (item._quantity <= 0)
                                    {
                                        Console.WriteLine("Item quantity must be greater than zero.");
                                    } else if (item._price <= 0)
                                    {
                                        Console.WriteLine("Item price must be greater than zero.");
                                    } else if (item._itemName == null && item._itemDescription == null && item._quantity <= 0 && item._price <= 0)
                                    {
                                        Console.WriteLine("Item name, description, quantity, and price cannot be null or zero.");
                                    }
                                    // Display an error message if the item creation fails
                                    Console.WriteLine("");
                                }
                                break;
                            case 2:
                                // Prompt the user to enter the ID of the item they want to update
                                Console.WriteLine("Enter the ID of the item you want to update:");
                                string UserOptionToUpdate = Console.ReadLine();
                                Console.WriteLine("");
                                // Read the user's input for the item ID
                                // Call the ParseInputToInteger method to parse the input to an integer
                                int parsedUserOptionToUpdate = Parsing.ParseInputToInteger(UserOptionToUpdate);
                                // Call the ParseInputToInteger method to parse the input to an integer
                                Console.WriteLine("");

                                if (parsedUserOptionToUpdate > 0) // Check if parsing was successful
                                {
                                    InventoryManager.UpdateInventoryItem(inventoryItems, parsedUserOptionToUpdate);
                                    // Call the UpdateInventoryItem method to update the specified item
                                    // The parsedUserOptionToUpdate is passed as an argument to identify the item
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine($"Invalid input: {parsedUserOptionToUpdate}"); 
                                    // Display an error message if the user enters an invalid item ID
                                    // The error message indicates that the input was not a valid integer
                                    Console.WriteLine("Please enter a valid integer for the item ID.");
                                    Console.WriteLine("");
                                }
                            
                                break;
                            case 3:
                                // Call the method to view all inventory items
                                InventoryManager.ShowInventoryItems(inventoryItems);
                                // Call the ShowInventoryItems method to display all items in the inventory
                                break;
                            case 4:
                                Console.WriteLine("Search for an item by: ID, Name, Type, Brand.");
                                Console.WriteLine("Input 'ID', 'Name' or 'Type' and press Enter");
                                Console.WriteLine("");
                                // Prompt the user to choose a search option
                                Console.Write("Enter your choice (ID/Name/Type/Brand): " );
                                string searchOption = Console.ReadLine()?.Trim().ToLower();
                                Console.WriteLine("");

                                if (searchOption.Trim().ToLower()  == "id")
                                {
                                    Console.WriteLine("Enter the ID of the item you want to view:");
                                    if (int.TryParse(Console.ReadLine(), out int itemId) && itemId > 0)
                                    {
                                        InventoryManager.ShowSpecificItemById(inventoryItems, itemId);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input. Please enter a valid positive integer for the item ID.");
                                    }
                                }
                                else if (searchOption.Trim().ToLower()  == "name")
                                {
                                    Console.WriteLine("Enter the Name of the item you want to view:");
                                    string itemName = Console.ReadLine();
                                    Console.WriteLine("");
                                    InventoryManager.ShowSpecificItemByName(inventoryItems, itemName);
                                }
                                else if (searchOption.Trim().ToLower() == "type")
                                {
                                    Console.WriteLine("Enter the Type of the item you want to view:");
                                    string itemType = Console.ReadLine();
                                    Console.WriteLine("");
                                    InventoryManager.ShowSpecificItemByType(inventoryItems, itemType);
                                }
                                else if (searchOption.Trim().ToLower()  == "brand")
                                {
                                    Console.WriteLine("Enter the Brand of the item you want to view:");
                                    string itemBrand = Console.ReadLine();
                                    Console.WriteLine("");
                                    InventoryManager.ShowSpecificItemByBrand(inventoryItems, itemBrand);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid option. Please enter: ID, Name, Type, Brand.");
                                    Console.WriteLine("");
                                }
                                Console.WriteLine("");
                                break;
                            case 5:
                                // Call the method to delete an inventory item
                                Console.WriteLine("Enter the ID of the item you want to delete:");
                                string UserOptionToDelete = Console.ReadLine();
                                Console.WriteLine("");
                                // Read the user's input for the item ID
                                // Call the ParseInputToInteger method to parse the input to an integer
                                int parsedUserOptionToDelete = Parsing.ParseInputToInteger(UserOptionToDelete);
                                // Call the ParseInputToInteger method to parse the input to an integer
                                Console.WriteLine("");
                                if (parsedUserOptionToDelete > 0) // Check if parsing was successful
                                {
                                    InventoryManager.DeleteInventoryItem(inventoryItems, parsedUserOptionToDelete);
                                    // Call the DeleteInventoryItem method to delete the specified item
                                    // The parsedUserOptionToDelete is passed as an argument to identify the item
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine($"Invalid input: {parsedUserOptionToDelete}"); 
                                    // Display an error message if the user enters an invalid item ID
                                    // The error message indicates that the input was not a valid integer
                                    Console.WriteLine("Please enter a valid integer for the item ID.");
                                    Console.WriteLine("");
                                }
                                break;
                            case 6:
                                Console.WriteLine("Exiting the Inventory Management System. Goodbye!");
                                running = false; // Set the flag to exit the loop
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please select a valid option.");
                                Console.WriteLine("");
                                // Display an error message if the user enters an invalid option
                                break;
                            }
                    } else 
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                        // Display an error message if the user enters an invalid input
                    }
            }
        }
    }
}
// InventoryManager.cs
// Description: This file contains a class with methods to manage inventory items.
using System;

namespace InventoryManagementSystem
{
    public class InventoryManager{

        public static InventoryItem CreateInventoryItem(){
            // This method creates a new inventory item.
            // The user is prompted to enter the item name, description, quantity, and price.

            Console.WriteLine("Enter the item name:");
            string itemName = Console.ReadLine();
            Console.WriteLine("");
            // Read the item name from the console input
            Console.WriteLine("Enter the item brand: example - Apple");
            string itemBrand = Console.ReadLine();
            Console.WriteLine("");
            // Read the item brand from the console input
            Console.WriteLine("Enter the item description:");
            string itemDescription = Console.ReadLine();
            Console.WriteLine("");
            // Read the item description from the console input
            Console.WriteLine("Enter the item quantity:");
            int itemQuantity = int.TryParse(Console.ReadLine(), out itemQuantity) ? itemQuantity : 0;
            Console.WriteLine("");
            // Read the item quantity from the console input and parse it as an integer
            Console.WriteLine("Enter the item price:");
            decimal itemPrice = decimal.TryParse(Console.ReadLine(), out itemPrice) ? itemQuantity : 0;
            Console.WriteLine("");
            // Read the item price from the console input and parse it as a double
            Console.WriteLine("Enter the item type:");
            // Prompt the user to enter the item type
            string itemType = Console.ReadLine();
            Console.WriteLine("");
            // Read the item type from the console input

            if(string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(itemBrand) || string.IsNullOrEmpty(itemDescription) || string.IsNullOrEmpty(itemType) || itemQuantity <= 0 || itemPrice <= 0)
            // Check if any of the input values are invalid (empty or negative)
            {
                Console.WriteLine("Invalid input. Please enter valid item details.");
                Console.WriteLine("");
                return null;
                // Display an error message and return null if the input is invalid
            } else
            {
                return new InventoryItem(itemName, itemBrand, itemDescription, itemQuantity, itemPrice, itemType);
            }
            // Create a new InventoryItem object with the provided details and return it 
        }

        public static void ShowInventoryItems(Dictionary<int, InventoryItem> inventoryItems)
        {
            const int itemsPerPage = 5;
            // Number of items to display per page
            int totalItems = inventoryItems.Count;
            // Total number of items in the inventory
            // Calculate the total number of pages based on the number of items and items per page
            int totalPages = (int)Math.Ceiling(totalItems / (double)itemsPerPage);
            // Total number of pages
            // Initialize the current page to 1
            // This variable keeps track of the current page being displayed
            // The current page is used to determine which items to display on the screen
            int currentPage = 1;
            // This variable is used to keep track of the current page being displayed
            // Check if there are any items in the inventory
            // If there are no items, display a message and return
            // The return statement exits the method if there are no items to display

            if (totalItems == 0)
            {
                Console.WriteLine("No items in inventory.");
                Console.WriteLine("");
                return;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Viewing inventory items (Page {currentPage} of {totalPages}):");
                Console.WriteLine("");

                // Get the items for the current page
                var itemsToDisplay = inventoryItems
                    .Skip((currentPage - 1) * itemsPerPage)
                    .Take(itemsPerPage);
                    // Skip the items for the current page and take the specified number of items
                    // Display the items for the current page

                foreach (var item in itemsToDisplay)
                {
                    Console.WriteLine($"Item ID: {item.Key}");
                    item.Value.DisplayItemDetails();
                    // Display the details of each inventory item
                    // The item ID is displayed as the key of the dictionary
                    // The item details are displayed using the DisplayItemDetails method of the InventoryItem class
                    Console.WriteLine("");
                }

                Console.WriteLine($"Page {currentPage}/{totalPages}");
                Console.WriteLine("Enter 'N' for next page, 'P' for previous page, or 'X' to Exit:");
                Console.WriteLine("");
                

                string? input = Console.ReadLine()?.Trim().ToLower();

                if (input?.Trim().ToLower() == "n" && currentPage < totalPages)
                {
                    currentPage++;
                }
                else if (input?.Trim().ToLower() == "p" && currentPage > 1)
                {
                    currentPage--;
                }
                else if (input?.Trim().ToLower() == "x")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }

        public static void ShowSpecificItemById(Dictionary<int, InventoryItem> inventoryItems, int parsedItemId)
        {
            // This method displays a specific inventory item based on the provided item ID.
            // It takes a dictionary of inventory items and the item ID as parameters.

            if (inventoryItems.ContainsKey(parsedItemId) && inventoryItems.Count > 0)
            // Check if the item ID exists in the inventory and if there are items in the inventory
            {
                Console.WriteLine("Viewing specific inventory item...");
                Console.WriteLine("");
                inventoryItems[parsedItemId].DisplayItemDetails();
                Console.WriteLine("");
                // Display a message indicating that a specific item is being viewed
            }
            else
            {
                Console.WriteLine($"Item with ID {parsedItemId} not found in inventory.");
                // Display an error message if the item ID is not found
                Console.WriteLine("");
            }
        }
        public static void ShowSpecificItemByName(Dictionary<int, InventoryItem> inventoryItems, string itemName)
        {
            // This method displays a specific inventory item based on the provided item name.
            // It takes a dictionary of inventory items and the item name as parameters.

            if (inventoryItems.Count > 0)
            // Check if there are any items in the inventory
            {
                Console.WriteLine($"Viewing items with name containing '{itemName}'..."); // Updated message
                // Display a message indicating that items with the specified name are being viewed
                // Initialize a boolean variable to track if any items were found
                Console.WriteLine("");
                bool found = false;
                // Initialize a boolean variable to track if any items were found 

                foreach (var item in inventoryItems)
                {
                    if (item.Value._itemName.Trim().ToLower().Contains(itemName.Trim().ToLower()))
                    // Check if the item's _itemName contains the provided name (case-insensitive)
                    {
                        item.Value.DisplayItemDetails();
                        Console.WriteLine("");
                        found = true;
                        // Display the details of the matching inventory item
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"No items found with the name containing '{itemName}'.");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("No items in inventory.");
                // Display a message indicating that there are no items in the inventory
                Console.WriteLine("");
            }
        }

        public static void ShowSpecificItemByBrand(Dictionary<int, InventoryItem> inventoryItems, string itemBrand)
        {
            // This method displays a specific inventory item based on the provided item brand.
            // It takes a dictionary of inventory items and the item brand as parameters.

            if (inventoryItems.Count > 0)
            // Check if there are any items in the inventory
            {
                Console.WriteLine($"Viewing items with brand containing '{itemBrand}'..."); // Updated message
                // Display a message indicating that items with the specified brand are being viewed
                // Initialize a boolean variable to track if any items were found
                Console.WriteLine("");
                bool found = false;
                // Initialize a boolean variable to track if any items were found 

                foreach (var item in inventoryItems)
                {
                    if (item.Value._itemBrand.Trim().ToLower().Contains(itemBrand.Trim().ToLower()))
                    // Check if the item's _itemBrand contains the provided brand (case-insensitive)
                    {
                        item.Value.DisplayItemDetails();
                        Console.WriteLine("");
                        found = true;
                        // Display the details of the matching inventory item
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"No items found with the brand containing '{itemBrand}'.");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("No items in inventory.");
                // Display a message indicating that there are no items in the inventory
                Console.WriteLine("");
            }
        }

        public static void ShowSpecificItemByType(Dictionary<int, InventoryItem> inventoryItems, string itemType)
        {
            // This method displays a specific inventory item based on the provided item type.
            // It takes a dictionary of inventory items and the item type as parameters.

            if (inventoryItems.Count > 0)
            // Check if there are any items in the inventory
            {
                Console.WriteLine($"Viewing items with type '{itemType}'..."); // Updated message
                // Display a message indicating that items with the specified type are being viewed
                Console.WriteLine("");
                bool found = false;
                // Initialize a boolean variable to track if any items were found 

                foreach (var item in inventoryItems)
                {
                    if (item.Value._itemType.Trim().ToLower().Contains(itemType.Trim().ToLower()))
                    // Check if the item's _itemType contains the provided type (case-insensitive)
                    {
                        item.Value.DisplayItemDetails();
                        Console.WriteLine("");
                        found = true;
                        // Display the details of the matching inventory item
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"No items found with the type '{itemType}'.");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("No items in inventory.");
                // Display a message indicating that there are no items in the inventory
                Console.WriteLine("");
            }
        }

        public static void UpdateInventoryItem(Dictionary<int, InventoryItem> inventoryItems, int parsedItemId)
        {
            // This method updates an existing inventory item based on the provided item ID.
            // It takes a dictionary of inventory items and the item ID as parameters.

            Console.WriteLine("Updating inventory item...");
            // Display a message indicating that an inventory item is being updated
            Console.WriteLine(inventoryItems[parsedItemId]._itemName);
            // Display the name of the item being updated
            Console.WriteLine("");

            if (inventoryItems.ContainsKey(parsedItemId) && inventoryItems.Count > 0)
            // Check if the item ID exists in the inventory and if there are items in the inventory
            {

                // Display a message indicating that an existing item is being updated
                Console.WriteLine("Choose an option to update:");
                Console.WriteLine("1. Update item name");
                Console.WriteLine("2. Update item description");
                Console.WriteLine("3. Update item quantity");
                Console.WriteLine("4. Update item price");
                Console.WriteLine("5. Update item type");
                Console.WriteLine("6. Update item brand");
                Console.WriteLine("7. Update all item details");
                Console.WriteLine("8. Exit");
                Console.WriteLine("");
                // Display a menu of options for the user to choose from
                Console.Write("Enter your choice (1-6): ");
                // Prompt the user to enter their choice from the menu
                string option = Console.ReadLine();
                Console.WriteLine("");
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
                else if (int.TryParse(option, out parsedOption) && parsedOption < 1 || parsedOption > 6)
                {
                    Console.WriteLine($"Invalid input: {option}");
                    Console.WriteLine("Please enter a number between 1 and 8.");
                    Console.WriteLine("");
                    // Display an error message if the user enters a string input
                }
                else if (int.TryParse(option, out parsedOption) && parsedOption >= 0 || parsedOption <= 6){
                    // This loop continues until the user enters a valid option (1-6)
                    // It ensures that the program keeps running until a valid input is provided
                    // The loop will break if the user enters a valid option
                    // The loop will also break if the user enters an invalid option

                    switch (parsedOption)
                    {
                        case 1:
                            Console.WriteLine("Enter new item name:");
                            string newItemName = Console.ReadLine();
                            if (string.IsNullOrEmpty(newItemName))
                            { 
                                Console.WriteLine("Invalid name entered. Keeping existing value.");
                                newItemName = inventoryItems[parsedItemId]._itemName;
                            } else if (!string.IsNullOrEmpty(newItemName))
                            {
                                Console.WriteLine("Updating item name...");
                                // Display a message indicating that the item name is being updated
                                inventoryItems[parsedItemId].UpdateItemName(newItemName);
                                // Update the item name of the specified inventory item
                                inventoryItems[parsedItemId].DisplayItemDetails();
                                // Display the updated item details
                                Console.WriteLine("");       
                            }                     
                            break;
                        case 2:
                            Console.WriteLine("Enter new item description:");
                            string newItemDescription = Console.ReadLine();
                            if (string.IsNullOrEmpty(newItemDescription))
                            {
                                Console.WriteLine("Invalid description entered. Keeping existing value.");
                                newItemDescription = inventoryItems[parsedItemId]._itemDescription;
                            } else if (!string.IsNullOrEmpty(newItemDescription))
                            {
                                Console.WriteLine("Updating item description...");
                                // Display a message indicating that the item description is being updated
                                inventoryItems[parsedItemId].UpdateItemDescription(newItemDescription);
                                // Update the item description of the specified inventory item
                                inventoryItems[parsedItemId].DisplayItemDetails();
                                // Display the updated item details
                                Console.WriteLine("");
                            }                     
                            break;
                        case 3:
                            Console.WriteLine("Enter new item quantity:");
                            string quantityInput = Console.ReadLine();
                            int newItemQuantity; // Declare newItemQuantity here

                            if (string.IsNullOrEmpty(quantityInput))
                            {
                                Console.WriteLine("Invalid quantity entered. Keeping existing value.");
                            }
                            else if (int.TryParse(quantityInput, out newItemQuantity) && newItemQuantity >= 0)
                            {
                                Console.WriteLine("Updating item quantity...");
                                inventoryItems[parsedItemId].UpdateItemQuantity(newItemQuantity);
                                inventoryItems[parsedItemId].DisplayItemDetails();
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("Invalid quantity entered. Keeping existing value.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter new item price:");
                            string priceInput = Console.ReadLine();
                            decimal newItemPrice; // Declare newItemPrice here

                            if (string.IsNullOrEmpty(priceInput))
                            {
                                Console.WriteLine("Invalid price entered. Keeping existing value.");
                            }
                            else if (decimal.TryParse(priceInput, out newItemPrice) && newItemPrice >= 0)
                            {
                                Console.WriteLine("Updating item price...");
                                inventoryItems[parsedItemId].UpdateItemPrice(newItemPrice);
                                inventoryItems[parsedItemId].DisplayItemDetails();
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("Invalid price entered. Keeping existing value.");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Enter new item type:");
                            string newItemType = Console.ReadLine();
                            if (string.IsNullOrEmpty(newItemType))
                            {
                                Console.WriteLine("Invalid type entered. Keeping existing value.");
                                newItemType = inventoryItems[parsedItemId]._itemType;
                            } else if (!string.IsNullOrEmpty(newItemType))
                            {
                                Console.WriteLine("Updating item type...");
                                inventoryItems[parsedItemId].UpdateItemType(newItemType);
                                inventoryItems[parsedItemId].DisplayItemDetails();
                                Console.WriteLine("");
                            }                     
                            break;  
                        case 6:
                            Console.WriteLine("Enter new item brand:");
                            string newItemBrand = Console.ReadLine();
                            if (string.IsNullOrEmpty(newItemBrand))
                            { 
                                Console.WriteLine("Invalid brand entered. Keeping existing value.");
                                newItemName = inventoryItems[parsedItemId]._itemBrand;
                            } else if (!string.IsNullOrEmpty(newItemBrand))
                            {
                                Console.WriteLine("Updating item name...");
                                // Display a message indicating that the item brand is being updated
                                inventoryItems[parsedItemId].UpdateItemName(newItemBrand);
                                // Update the item brand of the specified inventory item
                                inventoryItems[parsedItemId].DisplayItemDetails();
                                // Display the updated item details
                                Console.WriteLine("");       
                            }                     
                            break;  
                        case 7:
                            Console.WriteLine("Enter new item name (leave blank to keep current):");
                            string newItemNameFullUpdate = Console.ReadLine();
                            if (!string.IsNullOrEmpty(newItemNameFullUpdate))
                            {
                                inventoryItems[parsedItemId].UpdateItemName(newItemNameFullUpdate);
                            } else if (string.IsNullOrEmpty(newItemNameFullUpdate))
                            {
                                Console.WriteLine("Invalid name entered. Keeping existing value.");
                            }
                             Console.WriteLine("Enter new item description (leave blank to keep current):");
                            string newItemDescriptionFullUpdate = Console.ReadLine();
                            if (!string.IsNullOrEmpty(newItemDescriptionFullUpdate))
                            {
                                inventoryItems[parsedItemId].UpdateItemDescription(newItemDescriptionFullUpdate);          
                                                      
                            } else if (string.IsNullOrEmpty(newItemDescriptionFullUpdate))
                            {
                                Console.WriteLine("Invalid description entered. Keeping existing value.");
                                newItemDescriptionFullUpdate = inventoryItems[parsedItemId]._itemDescription;
                            }              
                            Console.WriteLine("Enter new item quantity (leave blank to keep current):");
                            string quantityInputFullUpdate = Console.ReadLine();
                            if (!string.IsNullOrEmpty(quantityInputFullUpdate) && int.TryParse(quantityInputFullUpdate, out int newItemQuantityFullUpdate))
                            {
                                inventoryItems[parsedItemId].UpdateItemQuantity(newItemQuantityFullUpdate);
                            }
                            else if (!string.IsNullOrEmpty(quantityInputFullUpdate))
                            {
                                Console.WriteLine("Invalid quantity entered. Keeping existing value.");
                            }

                            Console.WriteLine("Enter new item price (leave blank to keep current):");
                            string priceInputFullUpdate = Console.ReadLine();
                            if (!string.IsNullOrEmpty(priceInputFullUpdate) && decimal.TryParse(priceInputFullUpdate, out decimal newItemPriceFullUpdate))
                            {
                                inventoryItems[parsedItemId].UpdateItemPrice(newItemPriceFullUpdate);
                            }
                            else if (!string.IsNullOrEmpty(priceInputFullUpdate))
                            {
                                Console.WriteLine("Invalid price entered. Keeping existing value.");
                            }
                            inventoryItems[parsedItemId].DisplayItemDetails();
                            Console.WriteLine("");
                            break;
                        case 8:
                            return; // Exit from the update menu
                    }
                }
            }
            else
            {
                Console.WriteLine($"Item with ID {parsedItemId} not found in inventory.");
                // Display an error message if the item ID is not found
                Console.WriteLine("");
            }
        }

        public static void DeleteInventoryItem(Dictionary<int, InventoryItem> inventoryItems, int parsedItemId)
        {
            // This method deletes an inventory item based on the provided item ID.
            // It takes a dictionary of inventory items and the item ID as parameters.

            if (inventoryItems.ContainsKey(parsedItemId) && inventoryItems.Count > 0)
            // Check if the item ID exists in the inventory and if there are items in the inventory
            {
                Console.WriteLine($"Deleting item with ID {inventoryItems[parsedItemId]._itemName}...");
                inventoryItems.Remove(parsedItemId);
                // Remove the specified item from the inventory
                Console.WriteLine("Item deleted successfully.");
                Console.WriteLine("");
                // Display a message indicating that the item has been deleted
            }
            else
            {
                Console.WriteLine($"Item with ID {parsedItemId} not found in inventory.");
                // Display an error message if the item ID is not found
                Console.WriteLine("");
            }
        }
    }
}
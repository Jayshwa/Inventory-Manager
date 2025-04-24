// InventoryItem.cs
// Description: This file contains a class that represents an inventory item in the inventory management system.
// It implements the IInventoryItem interface, which defines the properties and methods for inventory items.
using System;

namespace InventoryManagementSystem
{
    public class InventoryItem : IInventoryItem
        // This class represents an inventory item in the inventory management system.
        // It implements the IInventoryItem interface, which defines the properties and methods for inventory items.
        // The class contains private fields to store the properties of the inventory item.
        // It also provides methods to update and display the item details.
    {
        // Public get, private set for properties
        public string _itemName { get; set; }
        public string _itemBrand { get; set; }
        public string _itemDescription { get; set; }
        public int _quantity { get; set; }
        public decimal _price { get; set; }
        public string _itemType { get; set; }
        // These are private fields that store the properties of the inventory item.

        public InventoryItem(string itemName, string itemBrand, string itemDescription, int quantity, decimal price, string itemType)
        {
            _itemName = itemName;
            _itemBrand = itemBrand;
            _itemDescription = itemDescription;
            _quantity = quantity;
            _price = price;
            _itemType = itemType;
        }

        public void UpdateItemName(string newItemName)
        {
            _itemName = newItemName;
            // This method updates the item name with a new value.
            Console.WriteLine($"Item name updated to: {_itemName}");
            // Display a message indicating the item name has been updated
        }

        public void UpdateItemBrand(string newBrand)
        {
            _itemType = newBrand;
            // This method updates the item brand with a new value.
            Console.WriteLine($"Item brand updated to: {_itemBrand}");
            // Display a message indicating the item brand has been updated
        }
        public void UpdateItemDescription(string newItemDescription)
        {
            _itemDescription = newItemDescription;
            // This method updates the item description with a new value.
            Console.WriteLine($"Item description updated to: {_itemDescription}");
            // Display a message indicating the item description has been updated
        }
        public void UpdateItemQuantity(int newQuantity)
        {
            _quantity = newQuantity;
            // This method updates the item quantity with a new value.
            Console.WriteLine($"Item quantity updated to: {_quantity}");
            // Display a message indicating the item quantity has been updated
        }
        public void UpdateItemPrice(decimal newPrice)
        {
            _price = newPrice;
            // This method updates the item price with a new value.
            Console.WriteLine($"Item price updated to: {_price}");
            // Display a message indicating the item price has been updated
        }

        public void UpdateItemType(string newItemType)
        {
            _itemType = newItemType;
            // This method updates the item type with a new value.
            Console.WriteLine($"Item type updated to: {_itemType}");
            // Display a message indicating the item type has been updated
        }
        public void DisplayItemDetails()
        {
            // This method displays the details of the inventory item.
            Console.WriteLine($"Item Name: {_itemName}");
            Console.WriteLine($"Item Brand: {_itemBrand}");
            Console.WriteLine($"Item Description: {_itemDescription}");
            Console.WriteLine($"Item Quantity: {_quantity}");
            Console.WriteLine($"Item Price: {_price}");
            Console.WriteLine($"Item Type: {_itemType}");
            Console.WriteLine("");
            // Display the item details in a formatted manner
        }

    }
}
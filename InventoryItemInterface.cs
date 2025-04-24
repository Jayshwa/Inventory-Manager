using System;

namespace InventoryManagementSystem
{
    public interface IInventoryItem
    {
        string _itemName { get; set; }
        string _itemBrand { get; set; }
        string _itemDescription { get; set; }
        int _quantity { get; set; }
        decimal _price { get; set; }
        string _itemType { get; set; }
        // These are the properties of the inventory item.
        // They are defined as public properties with get and set accessors.
        // The properties include item name, description, quantity, and price.
        // The get accessor allows reading the value of the property.

        void UpdateItemName(string newItemName);
        void UpdateItemDescription(string newItemDescription);
        void UpdateItemQuantity(int newQuantity);
        void UpdateItemPrice(decimal newPrice);
        void DisplayItemDetails();
        // This interface defines the properties and methods that an inventory item must implement.
        // It includes properties for item name, description, quantity, and price.
        // It also includes methods for updating these properties and displaying item details.
        // Any class that implements this interface must provide concrete implementations for these methods.
        // This allows for a consistent way to manage inventory items across different classes.
    }
}
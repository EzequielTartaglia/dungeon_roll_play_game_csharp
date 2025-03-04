using System;
//Public class to can use in "other window"

public class Inventory
{
    //Create a list of items inside it
    public List<Item> _items = new List<Item>();

    public Inventory()
    {
        _items = new List<Item>();
    }

    //Add item to the inventary (if exist change the quantity)
    public void AddItemToInventory(Item name)
    {

        bool itemExists = false;

        //Check if the item already exists in the inventory
        foreach (Item item in _items)
        {
            if (item._name == name._name)
            {
                item._quantity += name._quantity;
                itemExists = true;
                break;
            }
        }

        //If the item does not exist in the inventory, add it
        if (!itemExists)
        {
            _items.Add(name);

        }
    }

    public void Display()
    {


        //Display all the items (information for each element) in the list Inventory
        foreach (Item itemOfList in _items)
        {
            //Display all the information inside the element
            Console.WriteLine($"{itemOfList._name} - {itemOfList._quantity}");

        }
    }
}
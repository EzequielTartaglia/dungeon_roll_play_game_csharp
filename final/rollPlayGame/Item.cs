using System;
//Public class to can use in "other window"
public class Item
{
    public string _name;
    public int _quantity;

    //----------- Constructors section (templates)--------------

    //The default Item when we create
    public Item()
    {
        _name = "";
        _quantity = 0;
    }
    //With 1 parameter
    public Item(string name)
    {
        _name = name;
        _quantity = 1;
    }

    //With 2 parameters
    public Item(string name, int quantity)
    {
        _name = name;
        _quantity = quantity;
    }
        //----------- Constructors section (templates)--------------
    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------

    public string GetName()
    {
        //See the value of _name
        return _name;
    }
    public void SetName(string name)
    {
        //Put the value of _name
        _name = name;
    }
    public int GetQuantity()
    {
        //See the value of _quantity
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        //Put the value of _quantity
        _quantity = quantity;
    }
    public string DisplayItem( Item item){
        return $"{_name} - {_quantity}";
    }
    
    //----------------- Getter & Setter section -----------------
}
public class Producto{
    private string _name;
    private string _idProduct;
    private int _quantity;
    private double _price;

    public Producto(string name, string idProduct, int quantity, double price){
        _name = name;
        _idProduct = idProduct;
        _quantity = quantity;
        _price = price;
    }

    public double GetTotalCost()
    {
        return _price*_quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetIdProduct()
    {
        return _idProduct;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

}
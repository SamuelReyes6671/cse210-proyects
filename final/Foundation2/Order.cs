public class Order{
    private Customer _customer;
    private List<Producto>products;

    public Order(Customer customer)
    {
        this._customer = customer;
        this.products = new List<Producto>();
    }

    public void AddProduct(Producto product)
    {
        products.Add(product);
    }
    public double CalculateTotalCost()
    {
        double totalCost=0;
        foreach (Producto product in products)
        {
            totalCost+=product.GetTotalCost();

        }
        double shippingCost=_customer.IsInUSA()? 5:35;
        return totalCost+shippingCost;
    }
    public string GeneratePackingLabel()
    {
        string label = "";
        foreach (var product in products)
        {
            label += $"Product Name: {product.GetName()}, Product ID: {product.GetIdProduct()}\n";
        }
        return label;
    }

    public string GenerateShippingLabel()
    {
        string customerAddress = _customer.GetAddress().GetAddressString();
        return $"Customer Name: {_customer.GetName()}\nCustomer Address:\n{customerAddress}";
    }
}


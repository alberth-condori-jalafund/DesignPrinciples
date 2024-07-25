/*
* CalculateTotalPrice focuses solely on adding up the prices of the products in the cart,
* avoiding additional logic for discounts and taxes
*/
public class ShoppingCart
{
    private List<Product> products;

    public ShoppingCart()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double total = 0;

        foreach (var product in products)
        {
            total += product.Price;
        }

        return total;
    }
}

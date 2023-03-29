using System;

public class Order
{
	private List<Product> _productList;
	private Customer _customer;

	public List<Product> GetProductList()
	{
		return _productList;
	}
	public void PopulateList(List<Product> list)
	{
		_productList = list;
	}
	public Customer GetCustomer()
	{
		return _customer;
	}
	public void SetCustomer(Customer customer)
	{
		_customer = customer;
	}

	public Order(List<Product> productList, Customer customer)
	{
		_productList = productList;
		_customer = customer;
	}

	public void CalculateTotalPrice()
	{
		double sum = 0;
		foreach(Product product in _productList)
		{
			sum += product.CalculatePrice();
		}
		if(_customer.American())
		{
			sum += 5;
		}
		else
		{
			sum += 35;
		}
		Console.WriteLine($"Total: ${sum} (Shipping added)");
	}

	public void PackingLabel()
	{
		Console.WriteLine();
		foreach(Product product in _productList)
		{
			Console.WriteLine($"{product.GetQuantity()} {product.GetName()}, ID: {product.GetProductID()}");
		}
	}

	public void ShippingLabel()
	{
		Console.WriteLine();
		Console.WriteLine($"Shipping to {_customer.GetName()}");
		_customer.GetAddress().DisplayAddress();
	}
}

// Comment test